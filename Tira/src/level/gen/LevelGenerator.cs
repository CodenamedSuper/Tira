using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Tira;


public class LevelGenerator
{
    public static void Generate(Level level)
    {
        Coords start = Coords.Start();
        for (int y = 0; y < level.Size; y++)
        {
            for (int x = 0; x < level.Size; x++)
            {
                Vector2 worldPos = new Vector2(start.Value.X + x, start.Value.Y + y);
                Coords coords = new Coords(worldPos);


                level.PlaceTile(coords, Tiles.GRASS);
            }
        }
    }
}
