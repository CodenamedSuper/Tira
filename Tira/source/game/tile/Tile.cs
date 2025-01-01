using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tira;

public class Tile : Entity
{
    public Tile(string name)
    {
        Id.Name = name;
    }

    public override void Start()
    {
        Sprite sprite = new Sprite("tile/" + Id.Name);
        AddComponent(sprite);

        base.Start();
    }

}
