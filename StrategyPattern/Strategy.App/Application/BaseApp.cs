namespace Strategy.App.Application;

public abstract class BaseApp
{
    protected IPhoneAppInterface? _phoneAppInterface;
    protected IComputerAppInterface? _computerAppInterface;

    public void Act()
    {
        if (_phoneAppInterface is not null)
        {
            _phoneAppInterface.TouchScreen();
        }
        else
        {
            _computerAppInterface.PressKeyWord();
        }
        _phoneAppInterface?.TouchScreen();
    }

    public abstract void Render();
}