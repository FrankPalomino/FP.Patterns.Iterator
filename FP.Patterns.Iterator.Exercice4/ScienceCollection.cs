namespace FP.Patterns.Iterator.Exercice4
{
    public class ScienceCollection : IBookCollection
    {
        private readonly List<string> _science = [];
        public IIterator CreateIterator()
        {
            return new ScienceIterator(_science);
        }

        public void AddBook(string science)
        {
            _science.Add(science);
        }
    }
}
