using MonkeFrames.Extensions;

namespace MyExtension;

[Info("com.myname.myextension", "MyExtension", "1.0.0")]
public class Extension : FramesExtension
{
    public void OnLoad()
    {
        CreateMenu("MyExtension/Display Hello World", OnHelloWorldPressed);
    }

    public void OnHelloWorldPressed()
    {
        DisplayMessageBox("MyExtension", "Hello world!");
    }
}
