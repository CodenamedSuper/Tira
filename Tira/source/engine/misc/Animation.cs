using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tira;

public class Animation
{
    public string Name { get; set; } = "";
    public Vector2[] Frames { get; set; }

    public float Speed { get; set; } = 1;

    public int Size { get; set; } = 0;

    public Vector2 TileSize { get; set; } = Vector2.Zero;

    public Animation(float x, Vector2 tileSize, int size)
    {
        TileSize = tileSize;
        Size = size;
        Frames = new Vector2[Size];

        for(int i = 0; i < Size; i++)
        {
            Frames[i] = new Vector2(x, i * TileSize.Y);
        }
    }
}
