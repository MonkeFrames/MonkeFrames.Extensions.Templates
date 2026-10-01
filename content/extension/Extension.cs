using MonkeFrames.Extensions;

namespace MyExtension
{
    [Info("com.myname.myextension", "myextension", "1.0.0")]
    public class Extension : FramesExtension
    {
        public override void OnLoad()
        {
            CreateMenu("MyExtension/Display Hello World", OnHelloWorldPressed);
        }

        public void OnHelloWorldPressed()
        {
            ShowMessageBox("MyExtension", "Hello world!");
        }
    }
}
