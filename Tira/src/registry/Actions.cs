using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tira;

public class Actions
{
    public static readonly Func<Action> IDLE = Register(() => new IdleAction("idle"));

    public static readonly Func<Action> WALK = Register(() => new MoveAction("walk", 60));

    public static Func<Action> Register(Func<Action> action)
    {
        Registries.ACTIONS.Register(action().Name, action);

        return action;
    }
}
