using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tira;

public class World
{
    public Vector2 TileSize { get; set; } = new Vector2(22, 20);
    private TileMap TileMap { get; set; }
    private BitMap BitMap { get; set; }
    public List<Creature> Creatures { get; set; } = new List<Creature>();

    public World()
    {
    }

    public void Start()
    {
        TileMap = new TileMap(TileSize);
        BitMap = new BitMap(TileSize);

        PlaceTiles(new Vector2(0, 0), new Vector2(29, 13), Tiles.GRASS());

    }

    public void SpawnCreature(Vector2 coords, Creature creature)
    {
        Vector2 position = ToPosition(coords);

        creature.Position = position;

        Creatures.Add(creature);

        creature.Start();
    }

    public void PlaceTiles(Vector2 start, Vector2 end, Tile tile)
    {
        Vector2 coords = start;

        for(int i = 0; i < end.X + 1; i++)
        {
            for (int j = 0; j < end.Y + 1; j++)
            {
                coords = start + new Vector2(i, j);
                PlaceTile(coords, Tiles.GRASS());
            }
        }
    }

    public void PlaceTile(Vector2 coords, Tile tile)
    {
        TileMap.AddTile(coords, tile);
    }

    public void PlaceBit(Vector2 coords, Bit bit)
    {
        BitMap.AddBit(coords, bit);
    }

    public Vector2 Snap(Vector2 position)
    {

        float xStep = TileSize.X * 0.75f;
        float yStep = TileSize.Y;
        float halfHeight = TileSize.Y / 2f;

        float gridX = position.X / xStep;
        float gridY = position.Y / yStep;

        int roundedX = (int)Math.Round(gridX);
        int roundedY = (int)Math.Round(gridY);

        if (roundedX % 2 == 0)
        {

        }
        else
        {
            position.Y -= halfHeight;
            roundedY = (int)Math.Round(position.Y / yStep);
        }

        float snappedX = roundedX * xStep;
        float snappedY = roundedY * yStep + (roundedX % 2 == 0 ? 0 : halfHeight);

        return new Vector2(snappedX, snappedY);
    }
    public Vector2 ToCoordinates(Vector2 position)
    {
        float xStep = TileSize.X * 0.75f; 
        float yStep = TileSize.Y;        
        float halfHeight = TileSize.Y / 2f;

        float approxX = position.X / xStep;
        float approxY = position.Y / yStep;

        int hexX = (int)Math.Round(approxX);

        float adjustedY = position.Y - (hexX % 2 != 0 ? halfHeight : 0);
        int hexY = (int)Math.Round(adjustedY / yStep);

        return new Vector2(hexX, hexY);
    }

    public Vector2 ToPosition(Vector2 coords)
    {
        float xStep = TileSize.X * 0.75f;
        float yStep = TileSize.Y;
        float halfHeight = TileSize.Y / 2f;

        float posX = coords.X * xStep;
        float posY = coords.Y * yStep;

        if (coords.X % 2 != 0)
        {
            posY += halfHeight;
        }

        return new Vector2(posX, posY);
    }

    public Bit Up(Bit bit)
    {
        if (BitMap.Bits.ContainsKey(ToCoordinates(bit.Position)) && 
            BitMap.Bits.ContainsKey(ToCoordinates(bit.Position) + new Vector2(0, -1)))
        {
            return BitMap.Bits[(bit.Position) - new Vector2(0, 1)];
        }

        return null;
    }
    public Bit Down(Bit bit)
    {
        if (BitMap.Bits.ContainsKey(ToCoordinates(bit.Position)) &&
            BitMap.Bits.ContainsKey(ToCoordinates(bit.Position) + new Vector2(0, 1)))
        {
            return BitMap.Bits[(bit.Position) - new Vector2(0, 1)];
        }

        return null;
    }

    public void Update()
    {
        BitMap.Update();

        foreach (Creature creature in Creatures)
        {
            creature.Update();
        }

    }

    public void Draw()
    {
        TileMap.Draw();
        BitMap.Draw();

        foreach(Creature creature in Creatures)
        {
            creature.Draw();
        }

    }
}
