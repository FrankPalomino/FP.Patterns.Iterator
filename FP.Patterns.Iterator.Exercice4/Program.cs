// Create collections
using FP.Patterns.Iterator.Exercice4;

NovelCollection novels = new NovelCollection();
novels.AddBook("Pride and Prejudice");
novels.AddBook("To Kill a Mockingbird");
novels.AddBook("1984");

ScienceCollection scienceBooks = new ScienceCollection();
scienceBooks.AddBook("A Brief History of Time");
scienceBooks.AddBook("The Selfish Gene");
scienceBooks.AddBook("The Origin of Species");

HistoryCollection historyBooks = new HistoryCollection();
historyBooks.AddBook("Guns, Germs, and Steel");
historyBooks.AddBook("The History of the Ancient World");
historyBooks.AddBook("SPQR: A History of Ancient Rome");

// Create iterators
IIterator novelIterator = novels.CreateIterator();
IIterator scienceIterator = scienceBooks.CreateIterator();
IIterator historyIterator = historyBooks.CreateIterator();

// Traverse and display novel collection
Console.WriteLine("Novels:");
while (novelIterator.HasNext())
{
    Console.WriteLine(novelIterator.Next());
}
Console.WriteLine();

// Traverse and display science book collection
Console.WriteLine("Science Books:");
while (scienceIterator.HasNext())
{
    Console.WriteLine(scienceIterator.Next());
}
Console.WriteLine();

// Traverse and display history book collection
Console.WriteLine("History Books:");
while (historyIterator.HasNext())
{
    Console.WriteLine(historyIterator.Next());
}

Console.ReadLine(); // Keep console window open