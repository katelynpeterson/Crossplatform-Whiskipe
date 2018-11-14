using System;
using SharedViewModel;

namespace Ooui_Whiskipe
{
    class Program
    {
        static void Main(string[] args)
        {
            Forms.Init();
            UI.Port = 12345;
            UI.Host = "localhost";
            UI.Publish("/", new Page1() { BindingContext = new ViewModel() }.GetOouiElement());
            Process.Start("explorer", $"http://{UI.Host}:{UI.Port}");
            Console.ReadLine();
        }
    }
}
