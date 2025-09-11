using Raylib_cs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tira;

public class King : Character
{
    public King(string id) : base(id)
    {
    }

    public override void Start()
    {
        base.Start();

        Add(new Transform());
        Add(new VisualRect(Color.Red));
        Add(new ActionManager(Actions.IDLE()));
    }

    public override void Update()
    {
        ActionManager actionManager = Get<ActionManager>();

        bool moving = false;

        if (Raylib.IsKeyDown(KeyboardKey.W)) { actionManager.Perform(Actions.WALK(), Direction.Up); moving = true; }
        else if (Raylib.IsKeyDown(KeyboardKey.A)) { actionManager.Perform(Actions.WALK(), Direction.Left); moving = true; }
        else if (Raylib.IsKeyDown(KeyboardKey.S)) { actionManager.Perform(Actions.WALK(), Direction.Down); moving = true; }
        else if (Raylib.IsKeyDown(KeyboardKey.D)) { actionManager.Perform(Actions.WALK(), Direction.Right); moving = true; }

        if (!moving) actionManager.Perform(Actions.IDLE());

        base.Update();
    }
}
