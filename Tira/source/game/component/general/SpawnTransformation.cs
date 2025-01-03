using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Tira;

public class SpawnTransformation : Component
{
    public float Growth = 0.15f;

    public override void Start()
    {
        Parent.Scale = new Vector2(0, 0);

        base.Start();
    }

    public override void Update()
    {
        if(Parent.Scale.Y < Vector2.One.Y)
        {
            Parent.Scale += new Vector2(Growth, Growth);
        }

        base.Update();

    }
}

