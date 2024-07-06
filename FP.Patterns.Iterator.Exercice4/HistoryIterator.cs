namespace FP.Patterns.Iterator.Exercice4
{
    public class HistoryIterator : IIterator
    {
        private readonly List<string> _historyBooks;
        private int _position;

        public HistoryIterator(List<string> historyBooks)
        {
            _historyBooks = historyBooks;
            _position = 0;
        }
        public bool HasNext()
        {
            return _position < _historyBooks.Count;
        }

        public string Next()
        {
            return _historyBooks[_position++];
        }
    }
}
