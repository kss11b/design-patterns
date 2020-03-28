using System;
public class StandardQuack : IQuackBehavior
{
    public void Quack()
    {
        Console.WriteLine("QUACK QUACK QUACK");
    }
}