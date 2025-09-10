using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Tira;

public record struct Coords
{
    public Vector2 Value;
    public Coords(Vector2 value)
    {
        Value = value;
    }
    public Coords(int x, int y)
    {
        Value = new Vector2(x, y);
    }
    public Coords(int size)
    {
        Value = new Vector2(size);
    }
    public Coords Up() => new Coords(Value + new Vector2(0, -1));
    public Coords Down() => new Coords(Value + new Vector2(0, 1));
    public Coords Left() => new Coords(Value + new Vector2(-1, 0));
    public Coords Right() => new Coords(Value + new Vector2(1, 0));
    public Vector2 ToPosition()
    {
        return Value * Main.TILE_SIZE;
    }
    public static Vector2 ToPosition(Coords coords)
    {
        return coords.Value * Main.TILE_SIZE;
    }
    public static Coords FromPosition(Vector2 pos)
    {
        int x = (int)Math.Floor((double)pos.X / Main.TILE_SIZE);
        int y = (int)Math.Floor((double)pos.Y / Main.TILE_SIZE);
        return new Coords(x, y);
    }
    public static Coords Center()
    {
        return new Coords(0, 0);
    }
    public static Coords Start()
    {
        Vector2 worldSize = new Vector2(Main.GameManager.Level.Size);

        Vector2 startPos = Center().Value - (worldSize / 2);

        startPos.X = (float)Math.Floor(startPos.X);
        startPos.Y = (float)Math.Floor(startPos.Y);

        return new Coords(startPos + Vector2.One);
    }
    public static Coords End()
    {
        return new Coords(Main.GameManager.Level.Size);

    }
    public override string ToString()
    {
        return Value.ToString();
    }
}