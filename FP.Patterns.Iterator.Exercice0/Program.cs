using FP.Patterns.Iterator;

Word word = new Word("Hello");

foreach (char c in word)
{
    Console.WriteLine(c);
}