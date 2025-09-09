using Raylib_cs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Tira;

public class Main
{

    public static readonly int SCREEN_WIDTH = 800;
    public static readonly int SCREEN_HEIGHT = 450;
    public static readonly string GAME_NAME = "Tira";
    public static readonly int FPS = 60;
    public static readonly Color BACKGROUND_COLOR = new Color(100, 149, 237);
    public static readonly int TILE_SIZE = 16;
    public static readonly int ZOOM = 3;

    public static Camera2D Camera = new Camera2D();

    public static GameManager GameManager { get; set; } = new GameManager();

    public Main()
    {

        Raylib.InitWindow(SCREEN_WIDTH, SCREEN_HEIGHT, GAME_NAME);
        Raylib.SetTargetFPS(FPS);

        Start();

        while (!Raylib.WindowShouldClose())
        {
            Update(Raylib.GetFrameTime());

            Raylib.BeginDrawing();

            Draw();

            Raylib.EndDrawing();
        }

        Raylib.CloseWindow();
    }

    public void Start()
    {
        Camera.Zoom = ZOOM;
        Camera.Target = -new Vector2(SCREEN_WIDTH, SCREEN_HEIGHT) / (2 * Camera.Zoom);

        GameManager.Start();
    }
    public void Update(float gameTime)
    {
        GameManager.Update();
    }
    public void Draw()
    {
        Raylib.ClearBackground(BACKGROUND_COLOR);

        Raylib.BeginMode2D(Camera);

        GameManager.Draw();

        Raylib.EndMode2D();
    }
}
