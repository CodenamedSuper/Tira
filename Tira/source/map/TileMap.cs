using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tira;

public class TileMap
{
    public Vector2 TileSize { get; set; } = Vector2.Zero;

    public Dictionary<Vector2, Tile> Tiles { get; set; } = new Dictionary<Vector2, Tile>();

    public TileMap(Vector2 tileSize)
    {
        TileSize = tileSize;
    }

    public void AddTile(Vector2 coords, Tile tile)
    {
        tile.Position = new Vector2(coords.X, coords.Y) * new Vector2(TileSize.X - TileSize.X / 4.4f, TileSize.Y);
        if(coords.X % 2 == 0)
        {
            tile.Position = new Vector2(tile.Position.X, tile.Position.Y + TileSize.Y / 2);

        }
        Tiles.Add(coords, tile);
        tile.Start();
    }

    public void Draw()
    {
        foreach(Tile tile in Tiles.Values)
        {
            tile.Draw();
        }
    }


}
