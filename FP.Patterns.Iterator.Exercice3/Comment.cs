using System.Collections;

namespace FP.Patterns.Iterator.Exercice3
{
    public class Comment : IEnumerable<Replie>
    {
        private List<Replie> _replies = new List<Replie>();
        public string Value { get; set; }

        public Comment(string value) 
        {
            Value = value;
        }
        public IEnumerator<Replie> GetEnumerator()
        {
            return _replies.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Add(Replie item)
        {
            _replies.Add(item);
        }

        public void Remove(Replie item)
        {
            _replies.Remove(item);
        }
    }
}
