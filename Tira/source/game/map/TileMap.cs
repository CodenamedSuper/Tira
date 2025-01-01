using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
        coords = Vector2.Round(coords);

        float xStep = TileSize.X * 0.75f; 
        float yStep = TileSize.Y;        
        float halfHeight = TileSize.Y / 2f;

        float posX = coords.X * xStep;
        float posY = coords.Y * yStep;

        if (coords.X % 2 != 0)
        {
            posY += halfHeight; 
        }

        tile.Position = new Vector2(posX, posY);

        if(Tiles.ContainsKey(coords))
        {
            Tiles[coords] = tile;
        }
        else
        {
            Tiles.Add(coords, tile);
        }

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
