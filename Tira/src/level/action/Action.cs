using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tira;

public abstract class Action
{
    public string Name { get; set; } = string.Empty;
    public Character User { get; set; }
    public ActionManager ActionManager { get; set; }
    public Direction Direction { get; set; } = Direction.Down;

    public Action(string name)
    {
        Name = name;
    }

    public virtual void Start()
    {

    }
    public virtual void Update()
    {

    }
    public virtual void End()
    {

    }
    public virtual void Draw()
    {

    }
}
