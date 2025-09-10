using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tira;

public class Thing : Body
{
    public Thing(string id) : base(id)
    {
    }

    public override void Start()
    {
        Add(new Transform());
        Add(new Sprite(ID));
    }
}
