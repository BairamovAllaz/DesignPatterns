namespace Strategy.App.Application;

public class PhoneApp : BaseApp
{
    public PhoneApp()
    {
        _phoneAppInterface = new TouchableScreen();
    }

    public override void Render()
    {
        Console.WriteLine("I AM RENDERING PHONE THINGS");
    }
}