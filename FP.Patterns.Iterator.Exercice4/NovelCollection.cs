namespace FP.Patterns.Iterator.Exercice4
{
    public class NovelCollection : IBookCollection
    {
        private readonly List<string> _novels = [];
        public IIterator CreateIterator()
        {
            return new NovelIterator(_novels);
        }

        public void AddBook(string book)
        {
            _novels.Add(book);
        }
    }
}
