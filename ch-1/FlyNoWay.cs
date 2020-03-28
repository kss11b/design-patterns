using System;
class FlyNoWay : IFlyBehavior
{
    public void Fly()
    {
        Console.WriteLine("I cant fly");
    }
}