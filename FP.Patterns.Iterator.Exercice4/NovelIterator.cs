namespace FP.Patterns.Iterator.Exercice4
{
    public class NovelIterator : IIterator
    {
        private readonly List<string> _novels;
        private int _position;

        public NovelIterator(List<string> novels)
        {
            _novels = novels;
            _position = 0;
        }

        public bool HasNext()
        {
            return _position < _novels.Count;
        }

        public string Next()
        {
            return _novels[_position++];
        }
    }
}
