namespace Strategy.App.Application;
public class TouchableScreen : IPhoneAppInterface
{
    public void TouchScreen()
    {
        Console.WriteLine("Touchable screen touching");
    }
}
public class PreesScreen : IComputerAppInterface
{
    public void PressKeyWord()
    {
        Console.WriteLine("Keyboard press");
    }
}