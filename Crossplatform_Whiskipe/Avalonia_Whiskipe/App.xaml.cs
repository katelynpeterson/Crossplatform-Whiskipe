using Avalonia;
using Avalonia.Markup.Xaml;

namespace Avalonia_Whiskipe
{
    public class App : Application
    {
        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
