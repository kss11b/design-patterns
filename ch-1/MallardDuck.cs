using System;

public class MallardDuck : Duck{

    public MallardDuck()
    {
        quackBehavior = new StandardQuack();
        flyBehavior = new FlyWithWings();
    }
            // IFlyBehavior setFlyBehavior = new FlyWithWings();
            // IQuackBehavior setQuackBehavior = new StandardQuack();
    public override void display()
    {
        Console.WriteLine("Im a real mallard");
    }

}