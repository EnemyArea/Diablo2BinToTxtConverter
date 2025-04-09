namespace Diablo2BinToTxtConverter
{
    internal sealed class ParsedLine
    {
        private readonly List<ValuePair> _values =
        [
        ];

        public IEnumerable<ValuePair> Values => _values.AsReadOnly();

        public void AddValue(string columnName, object value)
        {
            _values.Add(new ValuePair(columnName, value));
        }

        public record ValuePair(string Key, object Value);
    }
}