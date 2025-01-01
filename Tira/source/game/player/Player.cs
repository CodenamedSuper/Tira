using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tira;

public class Player : Entity
{
    public override void Start()
    {

        AddComponent(new Sprite("tile/select"));

        Layer = 1;

        base.Start();
    }

    public override void Update()
    {

        Position = Main.WorldManager.World.Snap(Input.Mouse.GetWorldPosition() + new Vector2(GraphicsConfig.SCREEN_WIDTH / 2, GraphicsConfig.SCREEN_HEIGHT / 2) / Main.Camera.Zoom);

        if (Input.Mouse.LeftClick()) PlaceTile();


        base.Update();
    }

    public void PlaceTile()
    {
        World world = Main.WorldManager.World;

        world.PlaceBit(world.ToCoordinates(Position), Bits.TREE());
    }
}
