namespace Strategy.App;

public abstract  class Duck
{
    protected IQauckBehavior _qauckBehavior;
    protected IFlyBehavior _flyBehavior;

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