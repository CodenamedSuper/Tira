using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tira;

public class Tiles
{
    public static readonly Func<Tile> GRASS = Register(() => new Tile("grass"));

    public static Func<Tile> Register(Func<Tile> tile)
    {
        Registries.TILES.Register(tile().ID, tile);

        return tile;
    }
}
