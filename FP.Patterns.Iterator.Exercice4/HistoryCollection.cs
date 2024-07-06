namespace FP.Patterns.Iterator.Exercice4
{
    public class HistoryCollection : IBookCollection
    {
        private readonly List<string> _histories = [];
        public IIterator CreateIterator()
        {
            return new HistoryIterator(_histories);
        }

        public void AddBook(string book)
        {
            _histories.Add(book);
        }
    }
}
