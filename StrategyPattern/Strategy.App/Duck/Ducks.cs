namespace Strategy.App;
public class MallarDuck : Duck
{
    public MallarDuck()
    {
        _qauckBehavior = new Quack();
        _flyBehavior = new FlyWithWings();
    }
    public override void display()
    {
        Console.WriteLine("Displaying MallarDuck");
    }
}