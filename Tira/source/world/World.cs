using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Tira;

public class World
{
    public Vector2 TileSize { get; set; } = new Vector2(22, 20);
    public TileMap TileMap { get; set; } 

    public World()
    {
    }

    public void Start()
    {
        TileMap = new TileMap(TileSize);

        PlaceTiles(new Vector2(1, 1), new Vector2(25, 11), Tiles.GRASSLAND());

    }

    public void PlaceTiles(Vector2 start, Vector2 end, Tile tile)
    {
        Vector2 coords = start;

        for(int i = 0; i < end.X + 1; i++)
        {
            for (int j = 0; j < end.Y + 1; j++)
            {
                coords = start + new Vector2(i, j);
                PlaceTile(coords, Tiles.GRASSLAND());
            }
        }
    }

    public void PlaceTile(Vector2 coords, Tile tile)
    {
        TileMap.AddTile(coords, tile);
    }

    public void Update()
    {

    }

    public void Draw()
    {
        TileMap.Draw();
    }
}
