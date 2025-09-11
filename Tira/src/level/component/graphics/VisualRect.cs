using Raylib_cs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tira;

public class VisualRect : Component
{
    public Color Color { get; set; } = Color.Red;

    public VisualRect(Color color)
    {
        Color = color;
    }


    public override void Draw()
    {
        Transform transform = Parent.Get<Transform>();
        Raylib.DrawRectanglePro(new Rectangle(transform.Position.X, transform.Position.Y, transform.Size), transform.Size / 2, transform.Rotation, Color);


    }
}
