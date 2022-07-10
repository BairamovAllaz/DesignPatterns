using Strategy.App.Application;

namespace Strategy.App
{
    /// <summary>
    /// STRATEGY Pattern
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            BaseApp baseApp = new ComputerApp();
            baseApp.Act(); 
            baseApp.Render();
        }
    }
}