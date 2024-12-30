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

        PlaceTile(Vector2.Zero, Tiles.GRASSLAND());

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
