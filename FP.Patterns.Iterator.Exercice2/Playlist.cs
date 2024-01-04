using System.Collections;

namespace FP.Patterns.Iterator.Exercice2
{
    public class Playlist : IEnumerable<Song>
    {
        private List<Song> _songs = new List<Song>();

        public IEnumerator<Song> GetEnumerator()
        {
            return _songs.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Add(Song song)
        {
            _songs.Add(song);
        }

        public void Remove(Song song)
        {
            _songs.Remove(song);
        }
    }
}
