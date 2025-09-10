using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tira;

public class Level
{
    public int Size { get; set; } = 13;

    public Thing Thing = new Thing("thing");
    public TileMap TileMap { get; set; } = new TileMap();
    public void Start()
    {
        LevelGenerator.Generate(this);

        Thing.Start();
    }
    public void PlaceTile(Coords coords, Func<Tile> tile)
    {
        TileMap.Add(coords, tile());
    }
    public void Update()
    {
        Thing.Update();
    }
    public void Draw()
    {
        TileMap.Draw();

        Thing.Draw();
    }
}
