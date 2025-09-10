using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tira;

public class Level
{
    public Thing Thing = new Thing("thing");
    public void Start()
    {
        Thing.Start();
    }
    public void Update()
    {
        Thing.Update();
    }
    public void Draw()
    {
        Thing.Draw();
    }
}
