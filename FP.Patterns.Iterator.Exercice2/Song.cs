namespace FP.Patterns.Iterator.Exercice2
{
    public class Song
    {
        public string Title { get; set; }
        public string Artist { get; set; }
        public int Duration { get; set; }

        public Song(string title, string artist, int duration)
        {
            Title = title;
            Artist = artist;
            Duration = duration;
        }
    }
}
