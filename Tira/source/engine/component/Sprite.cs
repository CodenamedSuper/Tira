using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tira;

public class Sprite : Component
{
    public string Path { get; private set; }
    public Vector2 Size { get; protected set; }

    public Vector2 Coordinates { get; set; } = Vector2.Zero;
    public Color Color { get; set; } = Color.White;
    public float LayerOffset { get; set; } = 0;
    public SpriteEffects Effect { get; set; } = SpriteEffects.None;

    public Vector2 Offset { get; set; } = Vector2.Zero;

    public Texture2D texture2d;

    public Sprite(string path)
    {

        Path = path;

        FileStream fileStream = new FileStream("assets/sprites/" + path + ".png", FileMode.Open, FileAccess.Read);
        texture2d = Texture2D.FromStream(Main.Instance.GraphicsDevice, fileStream);
        fileStream.Close();

        Size = new Vector2(texture2d.Width, texture2d.Height);
    }

    public void ChangePath(string path)
    {
        Path = path;

        FileStream fileStream = new FileStream(path + ".png", FileMode.Open, FileAccess.Read);
        texture2d = Texture2D.FromStream(Main.Instance.GraphicsDevice, fileStream);
        fileStream.Close();

        Size = new Vector2(texture2d.Width, texture2d.Height);
    }


    public override void Draw()
    {
        Main.SpriteBatch.Draw(texture2d, Parent.Position + Offset, new Rectangle((int)Coordinates.X, (int)Coordinates.Y, texture2d.Width, texture2d.Height), Color, Parent.Rotation, new Vector2(texture2d.Width / 2, texture2d.Height / 2), Parent.Scale, Effect, (Parent.Layer + LayerOffset) * 0.001f);
    }
}
