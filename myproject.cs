using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryLib
{
    internal class myproject
    {
    }
}

public interface IButton
{
    void Paint();
}

public interface ICheckbox
{
    void Paint();
}


public interface IGUIFactory
{
    IButton CreateButton();
    ICheckbox CreateCheckbox();
}


public class WinButton : IButton
{
    public void Paint() => Console.WriteLine("Windows Button");
}

public class WinCheckbox : ICheckbox
{
    public void Paint() => Console.WriteLine("Windows Checkbox");
}


public class MacButton : IButton
{
    public void Paint() => Console.WriteLine("MacOS Button");
}

public class MacCheckbox : ICheckbox
{
    public void Paint() => Console.WriteLine("MacOS Checkbox");
}


public class WinFactory : IGUIFactory
{
    public IButton CreateButton() => new WinButton();
    public ICheckbox CreateCheckbox() => new WinCheckbox();
}

public class MacFactory : IGUIFactory
{
    public IButton CreateButton() => new MacButton();
    public ICheckbox CreateCheckbox() => new MacCheckbox();
}

