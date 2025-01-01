

namespace Tira;

public static class Input
{
    public static TiraMouse Mouse { get; private set; }
    public static TiraKeyboard Keyboard { get; private set; }

    public static void Initialize()
    {
        Keyboard = new TiraKeyboard();
        Mouse = new TiraMouse();
    }

    public static void Update()
    {
        Keyboard.Update();
        Mouse.Update();
    }
}
