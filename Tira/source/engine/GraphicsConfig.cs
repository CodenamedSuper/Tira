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
        Game1.Graphics.PreferredBackBufferWidth = SCREEN_WIDTH;
        Game1.Graphics.PreferredBackBufferHeight = SCREEN_HEIGHT;

        Game1.Graphics.SynchronizeWithVerticalRetrace = VSYNC;
        Game1.Graphics.IsFullScreen = FULLSCREEN;
        Game1.Graphics.HardwareModeSwitch = false;

        Game1.Graphics.ApplyChanges();
    } 
}