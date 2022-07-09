namespace Strategy.App
{
    /// <summary>
    /// STRATEGY Pattern
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Duck duck = new MallarDuck();
            duck.performFly();
            duck.performQuack();
            duck.display();
        }
    }


    public interface FlyBehavior
    {
        public void fly();
    }

    public interface QauckBehavior
    {
        public void quack();
    }

    public class FlyWithWings : FlyBehavior
    {
        public void fly()
        {
            Console.WriteLine("I am flying with wings");
        }
    }
    
    public class FlyNoWay : FlyBehavior
    {
        public void fly()
        {
            Console.WriteLine("I am not flying");
        }
    }

    public class Quack : QauckBehavior
    {
        public void quack()
        {
            Console.WriteLine("I am Quacking");
        }
    }
    public class Squak : QauckBehavior
    {
        public void quack()
        {
            Console.WriteLine("I am Squacking");
        }
    }
    public class MuteQuack : QauckBehavior
    {
        public void quack()
        {
            Console.WriteLine("I am mutequack");
        }
    }
    
    public abstract  class Duck
    {
        protected QauckBehavior _qauckBehavior;
        protected FlyBehavior _flyBehavior;

        public void performQuack()
        {
            _qauckBehavior.quack();
        }
        public void performFly()
        {
            _flyBehavior.fly();
        }
        public abstract void display();
    }

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

}