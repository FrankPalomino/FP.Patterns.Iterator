using System.Collections;

namespace FP.Patterns.Iterator
{
    public class WordIterator : IEnumerator
    {
        private char[] _word;
        private int _position;

        public WordIterator(string word)
        {
            _word = word.ToCharArray();
            _position = -1;
        }

        public object Current => _word[_position];

        public bool MoveNext()
        {
            if (_position < _word.Length - 1)
            {
                _position++;
                return true;
            }
            return false;
        }

        public void Reset()
        {
            _position = -1;
        }
    }
}
