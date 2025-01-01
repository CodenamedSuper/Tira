using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tira;

public class BitMap
{
    public Vector2 TileSize { get; set; } = Vector2.Zero;

    public Dictionary<Vector2, Bit> Bits { get; set; } = new Dictionary<Vector2, Bit>();

    public BitMap(Vector2 tileSize)
    {
        TileSize = tileSize;
    }

    public void AddBit(Vector2 coords, Bit bit)
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

        bit.Position = new Vector2(posX, posY);

        if(Bits.ContainsKey(coords))
        {
            Bits[coords] = bit;
        }
        else
        {
            Bits.Add(coords, bit);
        }

        bit.Start();
    }

    public void Update()
    {
        foreach (Bit bit in Bits.Values)
        {
            bit.Update();
        }
    }


    public void Draw()
    {
        foreach(Bit bit in Bits.Values)
        {
            bit.Draw();
        }
    }


}
