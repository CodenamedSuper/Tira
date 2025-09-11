using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tira;

public class Level
{
    public int Size { get; set; } = 13;
    public TileMap TileMap { get; set; } = new TileMap();

    public List<Entity> Entities { get; set; } = new List<Entity>();
    public void Start()
    {
        LevelGenerator.Generate(this);

        SpawnCharacter(Coords.Center(), Characters.KING);

    }
    public void PlaceTile(Coords coords, Func<Tile> tile)
    {
        TileMap.Add(coords, tile());
    }
    public void SpawnCharacter(Coords coords, Func<Character> character)
    {
        Character c = character();
        c.Start();
        c.Get<Transform>().Position = coords.ToPosition();
        Entities.Add(c);
    }
    public void DespawnCharacter(Character character)
    {
        Entities.Remove(character);
    }
    public void Update()
    {
        Entities.ForEach(entity => entity.Update());
    }
    public void Draw()
    {
        TileMap.Draw();

        Entities.ForEach(entity => entity.Draw());
    }
}
