using Microsoft.Xna.Framework;

namespace Tira;
public class GraphicsConfig
{
    public static int SCREEN_WIDTH = 0;
    public static int SCREEN_HEIGHT = 0;

    public static bool VSYNC = false;

    public static int FRAMERATE = 60;

    public static bool FULLSCREEN = true;

    public static Color BACKGROUND_COLOR = Color.Black;

    public static void Apply()
    {
        Main.Graphics.PreferredBackBufferWidth = SCREEN_WIDTH;
        Main.Graphics.PreferredBackBufferHeight = SCREEN_HEIGHT;

        Main.Graphics.SynchronizeWithVerticalRetrace = VSYNC;
        Main.Graphics.IsFullScreen = FULLSCREEN;
        Main.Graphics.HardwareModeSwitch = false;

        Main.Graphics.ApplyChanges();
    } 
}