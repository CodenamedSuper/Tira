using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tira;

public class TileMap
{
    public Dictionary<Coords, Tile> Tiles { get; set; } = new Dictionary<Coords, Tile>();

    public void Add(Coords coords, Tile tile)
    {
        if (Tiles.ContainsKey(coords)) return;

        tile.Start();
        tile.Get<Transform>().Position = coords.ToPosition();

        Tiles.Add(coords, tile);
    }

    public void Remove(Coords coords)
    {
        if (Tiles.ContainsKey(coords)) Tiles.Remove(coords);
    }

    public void Update()
    {
        Tiles.ToList().ForEach(tile => tile.Value.Update());

    }

    public void Draw()
    {
        Tiles.ToList().ForEach(tile => tile.Value.Draw());
    }
}