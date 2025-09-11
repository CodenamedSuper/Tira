using Raylib_cs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Tira;

public class MoveAction : Action
{
    public int Speed { get; set; } = 1;
    public MoveAction(string name, int speed) : base(name)
    {
        Speed = speed;
    }
    public override void Start()
    {
        Transform transform = User.Get<Transform>();

        if (Direction == Direction.Down) 
            transform.Position = new Vector2(transform.Position.X, transform.Position.Y + Speed * Raylib.GetFrameTime());
        else if (Direction == Direction.Left) 
            transform.Position = new Vector2(transform.Position.X - Speed * Raylib.GetFrameTime(), transform.Position.Y);
        else if (Direction == Direction.Up)
            transform.Position = new Vector2(transform.Position.X, transform.Position.Y - Speed * Raylib.GetFrameTime());
        else if (Direction == Direction.Right)
            transform.Position = new Vector2(transform.Position.X + Speed * Raylib.GetFrameTime(), transform.Position.Y);

    }
}
