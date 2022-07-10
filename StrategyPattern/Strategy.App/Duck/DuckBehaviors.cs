namespace Strategy.App;

public class FlyWithWings : IFlyBehavior
{
    public void fly()
    {
        Console.WriteLine("I am flying with wings");
    }
}
public class FlyNoWay : IFlyBehavior
{
    public void fly()
    {
        Console.WriteLine("I am not flying");
    }
}
public class Quack : IQauckBehavior
{
    public void quack()
    {
        Console.WriteLine("I am Quacking");
    }
}
public class Squak : IQauckBehavior
{
    public void quack()
    {
        Console.WriteLine("I am Squacking");
    }
}
public class MuteQuack : IQauckBehavior
{
    public void quack()
    {
        Console.WriteLine("I am mutequack");
    }
}