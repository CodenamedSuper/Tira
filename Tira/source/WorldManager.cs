using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tira;

public class WorldManager
{
    public World World;

    public void Start(World world)
    {
        World = world;
        World.Start();
    }
    public void Update()
    {
        World.Update();
    }

    public void Draw()
    {
        World.Draw();
    }
}
