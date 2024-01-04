using FP.Patterns.Iterator.Exercice2;

Playlist salsas = new Playlist()
{
    new Song("Colgado en tus manos", "Bustamante", 60),
    new Song("Retrato", "Gianmarco", 150)
};

foreach(Song song in salsas)
{
    Console.WriteLine($"{song.Artist}-{song.Title}");
}