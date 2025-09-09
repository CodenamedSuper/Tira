using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tira;

public class GameManager
{
    public Level Level { get; set; } = new Level();
    public void Start()
    {
        Level.Start();
    }
    public void Update()
    {
        Level.Update();
    }
    public void Draw()
    {
        Level.Draw();
    }
}
