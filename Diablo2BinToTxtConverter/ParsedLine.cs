namespace Diablo2BinToTxtConverter
{
    internal sealed class ParsedLine
    {
        private readonly List<ValuePair> _values =
        [
        ];

        public IEnumerable<ValuePair> Values => _values.AsReadOnly();

        public void AddValue(int byteIndex, string columnName, object value)
        {
            _values.Add(new ValuePair(byteIndex, columnName, value));
        }

        public record ValuePair(int ByteIndex, string Key, object Value);
    }
}