using FP.Patterns.Iterator.Exercice3;

Post post1 = new(PostType.Image);

Comment comment1 = new("Nice image")
{
    new Replie("I have agread"),
    new Replie("Really nice")
};

Comment comment2 = new("Not nice image")
{
    new Replie("Your are bad"),
    new Replie("Block her")
};

post1.Add(comment1);
post1.Add(comment2);

Console.WriteLine(post1.Type.ToString());
foreach(var comment in post1)
{
    Console.WriteLine("_______________");
    Console.WriteLine(comment.Value);
    foreach(var repli in comment)
    {
        Console.WriteLine(repli.Value);
    }
}

