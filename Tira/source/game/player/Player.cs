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

        Layer = 2;

        base.Start();
    }

    public override void Update()
    {

        Position = Game1.WorldManager.World.Snap(Input.Mouse.GetWorldPosition() + new Vector2(GraphicsConfig.SCREEN_WIDTH / 2, GraphicsConfig.SCREEN_HEIGHT / 2) / Game1.Camera.Zoom);

        if (Input.Mouse.LeftClick()) PlaceTile();


        base.Update();
    }

    public void PlaceTile()
    {
        World world = Game1.WorldManager.World;

        world.PlaceTile(world.ToCoordinates(Position), Tiles.GRASS());
    }
}
