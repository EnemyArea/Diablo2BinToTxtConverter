using Diablo2BinToTxtConverter.TypeDefs;
using System.Text;
using System.Text.Json;

namespace Diablo2BinToTxtConverter
{
    internal class BinFileParser
    {
        public ParseFile ParseFile(BinFile binFile)
        {
            using FileStream stream = File.Open(binFile.FilePath, FileMode.Open);
            using BinaryReader reader = new(stream, Encoding.ASCII, false);

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

            _ = reader.ReadInt32();

            List<ParsedLine> result =
            [
            ];

            while (stream.Position != stream.Length)
            {
                ParsedLine buffer = new();

                foreach (ITypeDef typeDef in binFile.TypeDef)
                {
                    object value = ReadValue(typeDef, reader);

                    if (typeDef is KeyedTypeDef keyedType)
                    {
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
                    }

                    buffer.AddValue(typeDef.Column,
                        typeDef.NullValue == null || !Equals(value.ToString(), typeDef.NullValue.ToString())
                            ? value
                            : "");
                }

                result.Add(buffer);
            }

            return new ParseFile(binFile, result);
        }

        private static object ReadValue(ITypeDef type, BinaryReader reader)
        {
            switch (type)
            {
                case UnusedTypeDef: return string.Empty;
                case KeyedTypeDef: return reader.ReadUInt16();
                case UInt8TypeDef: return reader.ReadSByte();
                case UInt16TypeDef: return reader.ReadUInt16();
                case UInt32TypeDef: return reader.ReadUInt32();
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