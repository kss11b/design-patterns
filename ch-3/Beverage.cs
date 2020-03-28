public abstract class Beverage {
    protected string description;

    public virtual string getDescription() 
    {
        return description;
    }

    public abstract double cost();
} 

public abstract class CondimentDecorator:Beverage 
{
    public override abstract string getDescription();
}

public class Espresso : Beverage
{
    public Espresso()
    {
        description = "Espresso";
    }

    public override double cost()
    {
        return 1.99;
    }
}

public class HouseBlend : Beverage
{
    public HouseBlend()
    {
        description = "House Blend";
    }

    public override double cost()
    {
        return .89;
    }
}

public class DarkRoast : Beverage
{
    public DarkRoast()
    {
        description = "DarkRoast";
    }

    public override double cost()
    {
        return .90;
    }
}

public class Mocha : CondimentDecorator
{
    Beverage beverage;

    public Mocha (Beverage beverage)
    {
        this.beverage = beverage;
    }

    public override string getDescription()
    {
        return beverage.getDescription() + ", Mocha";
    }

    public override double cost()
    {
        return beverage.cost() + .20;
    }
}

public class Whip : CondimentDecorator
{
    Beverage beverage;

    public Whip (Beverage beverage)
    {
        this.beverage = beverage;
    }

    public override string getDescription()
    {
        return beverage.getDescription() + ", Whip";
    }

    public override double cost()
    {
        return beverage.cost() + .10;
    }
}

public class Soy : CondimentDecorator
{
    Beverage beverage;

    public Soy (Beverage beverage)
    {
        this.beverage = beverage;
    }

    public override string getDescription()
    {
        return beverage.getDescription() + ", Soy";
    }

    public override double cost()
    {
        return beverage.cost() + .90;
    }
}