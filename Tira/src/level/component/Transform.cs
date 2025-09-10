using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Tira;

public class Transform : Component
{
    public Vector2 Position { get; set; } = Vector2.Zero;
    public Vector2 Size { get; set; } = new Vector2(Main.TILE_SIZE);
    public Vector2 Scale { get; set; } = Vector2.One;
    public int Layer { get; set; } = 0;
    public float Rotation { get; set; } = 0;

    public Transform()
    {

    }
}
