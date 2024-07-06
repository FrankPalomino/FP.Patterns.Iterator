namespace FP.Patterns.Iterator.Exercice4
{
    public class ScienceIterator : IIterator
    {
        private readonly List<string> _science;
        private int _position;

        public ScienceIterator(List<string> science)
        {
            _science = science;
            _position = 0;
        }

        public bool HasNext()
        {
            return _position < _science.Count;
        }

        public string Next()
        {
            return _science[_position++];
        }
    }
}
