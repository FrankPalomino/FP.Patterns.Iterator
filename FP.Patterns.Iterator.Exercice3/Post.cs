using System.Collections;

namespace FP.Patterns.Iterator.Exercice3
{
    public enum PostType
    {
        Text,
        Image,
        Video
    }
    public class Post : IEnumerable<Comment>
    {
        private readonly List<Comment> _comments = [];
        public PostType Type { get; set; } 

        public Post(PostType type)
        {
            Type = type;
        }
        public IEnumerator<Comment> GetEnumerator()
        {
            return _comments.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Add(Comment comment)
        {
            _comments.Add(comment);
        }

        public void Remove(Comment comment)
        {
            _comments.Remove(comment);
        }
    }
}
