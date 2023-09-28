using System.Collections;

namespace FP.Patterns.Iterator
{
    public class Word : IEnumerable
    {
        private string _word;

        public Word(string word)
        {
            _word = word;
        }
        public IEnumerator GetEnumerator()
        {
            return new WordIterator(_word);
        }
    }
}
