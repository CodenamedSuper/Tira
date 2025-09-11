using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tira;

public class ActionManager : Component
{
    public Action Action { get; set; }
    public Direction Direction { get; set; } = Direction.Down;

    public ActionManager(Action initialAction)
    {
        Action = initialAction;
        Perform(initialAction);

    }
    public ActionManager(Action initialAction, Direction direction)
    {
        Direction = direction;
        Perform(initialAction, direction);
    }
    public void Perform(Action action)
    {
        Action = action;
        Action.ActionManager = this;
        Action.User = Parent as Character;
        Action.Direction = Direction;
        Action.Start();
    }
    public void Perform(Action action, Direction direction)
    {
        Action = action;
        Action.ActionManager = this;
        Action.User = Parent as Character;
        Direction = direction;
        Action.Direction = Direction;
        Action.Start();
    }
    public bool IsActive()
    {
        return Action != null;
    }
    public override void Update()
    {
        Action.Update();

        base.Update();
    }
    public override void Draw()
    {
        Action.Draw();

        base.Draw();
    }
}
