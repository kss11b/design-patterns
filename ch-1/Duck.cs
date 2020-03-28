using System;

public abstract class Duck
{
    public abstract void display();
    public IFlyBehavior flyBehavior;
    public IQuackBehavior quackBehavior;

    public void performFly()
    {
        flyBehavior.Fly();
    }

    public void performQuack()
    {
        quackBehavior.Quack();
    }

    public void swim()
    {
        Console.WriteLine("All ducks float, even decoys");
    }
 

}