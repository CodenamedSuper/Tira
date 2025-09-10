using Raylib_cs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Tira;

public class Sprite : Component
{
    public Texture2D Texture { get; set; }
    public Vector2 Origin { get; set; } = Vector2.Zero;
    public string Path { get; set; } = string.Empty;

    public Sprite(string path)
    {
        Path = path;

        Image image = Raylib.LoadImage("assets/sprites/" + Path + ".png");
        Texture = Raylib.LoadTextureFromImage(image);
        Raylib.UnloadImage(image);

        Origin = new Vector2(Texture.Width, Texture.Height) / 2;
    }

    public void ChangeTexture(string path)
    {
        Path = path;

        Image image = Raylib.LoadImage("assets/sprites/" + Path + ".png");
        Texture = Raylib.LoadTextureFromImage(image);
        Raylib.UnloadImage(image);

        Origin = new Vector2(Texture.Width, Texture.Height) / 2;
    }

    public override void Draw()
    {
        Raylib.DrawTexturePro(Texture,
            new Rectangle(0f, 0f, Texture.Width, Texture.Height),
            new Rectangle(Parent.Get<Transform>().Position.X, Parent.Get<Transform>().Position.Y, Texture.Width, Texture.Height),
            Origin,
            Parent.Get<Transform>().Rotation,
            Color.White);
    }
}
