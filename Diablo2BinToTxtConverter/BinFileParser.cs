using Diablo2BinToTxtConverter.TypeDefs;
using System.Text;
using System.Text.Json;

namespace Diablo2BinToTxtConverter
{
    internal class BinFileParser
    {
        public ParsedBinFile ParseFile(BinFile binFile)
        {
            Dictionary<string, List<KeyFileStructure>> parsedKeys = LoadParsedKeys(binFile);

            using FileStream stream = File.Open(binFile.FilePath, FileMode.Open, FileAccess.Read, FileShare.Read);
            using BinaryReader reader = new(stream, Encoding.ASCII, false);

            // Read file-version and drop it
            _ = reader.ReadInt32();
            // stream.Seek(4156, SeekOrigin.Begin);

            List<ParsedLine> result =
            [
            ];

            while (stream.Position != stream.Length)
            {
                ParsedLine parsedLine = new();

                foreach (ITypeDef typeDef in binFile.TypeDef)
                {
                    object value = ReadValue(typeDef, reader);

                    value = CheckForKeyedType(typeDef, parsedKeys, value);

                    parsedLine.AddValue(typeDef.Column,
                        typeDef.NullValue == null || !Equals(value.ToString(), typeDef.NullValue.ToString())
                            ? value
                            : "");
                }

                result.Add(parsedLine);
            }

            return new ParsedBinFile(binFile, result);
        }

        private static object CheckForKeyedType(ITypeDef typeDef, Dictionary<string, List<KeyFileStructure>> parsedKeys,
            object value)
        {
            if (typeDef is not KeyedTypeDef keyedType)
            {
                return value;
            }

            foreach (string keyFilePath in keyedType.KeyFilePaths)
            {
                if (!parsedKeys.TryGetValue(keyFilePath, out List<KeyFileStructure>? keyList))
                {
                    continue;
                }

                KeyFileStructure? keyResult = keyList.Find(x => x.Id.ToString() == value.ToString());
                if (keyResult == null)
                {
                    continue;
                }

                if (keyResult.Key == keyedType.NullValue?.ToString())
                {
                    value = "";
                    continue;
                }

                value = keyResult.Key;
                break;
            }

            return value;
        }

        private static Dictionary<string, List<KeyFileStructure>> LoadParsedKeys(BinFile binFile)
        {
            Dictionary<string, List<KeyFileStructure>> parsedKeys = new();
            foreach (KeyValuePair<string, string> keyValuePair in binFile.KeyFilePaths)
            {
                string targetPath = Path.Combine(binFile.RootPath, keyValuePair.Value);
                List<KeyFileStructure>? jsonData =
                    JsonSerializer.Deserialize<List<KeyFileStructure>>(File.ReadAllText(targetPath));

                if (jsonData != null)
                {
                    parsedKeys.Add(keyValuePair.Key, jsonData);
                }
            }

            return parsedKeys;
        }

        private static object ReadValue(ITypeDef type, BinaryReader reader)
        {
            switch (type)
            {
                case UnusedTypeDef: return string.Empty;
                case KeyedTypeDef: return reader.ReadInt16();
                case Int8TypeDef: return reader.ReadByte();
                case Int16TypeDef: return reader.ReadInt16();
                case Int32TypeDef: return reader.ReadInt32();
                case Int64TypeDef: return reader.ReadInt64();
                case StringTypeDef stringTypeDef:
                    {
                        char[] chars = reader.ReadChars(stringTypeDef.Length);
                        return new string(chars).TrimEnd('\0');
                    }
                default:
                    throw new NotImplementedException();
            }
        }
    }
}