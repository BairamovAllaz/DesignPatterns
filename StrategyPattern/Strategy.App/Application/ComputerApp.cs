namespace Strategy.App.Application;

public class ComputerApp : BaseApp
{
    public ComputerApp()
    {
        _computerAppInterface = new PreesScreen();
    }
    public override void Render()
    {
        Console.WriteLine("I AM RENDERING COMPUTER THINGS");
    }
}