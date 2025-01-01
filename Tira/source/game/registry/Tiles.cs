using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tira;

public class Tiles
{
    public static Dictionary<Id, Func<Tile>> List = new Dictionary<Id, Func<Tile>>();

    public static readonly Func<Tile> GRASS = Register("grass");

    public static Func<Tile> Register(string name)
    {
        Func<Tile> tile = () => new Tile(name);
        List.Add(tile().Id, tile);

        return tile;

    }
}
