using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tira;

public class Creature : Entity
{
    public Creature(string name)
    {
        Id.Name = name;
    }
    public override void Start()
    {
        AnimatedSprite animatedSprite = new AnimatedSprite(Id.Name);
        AddComponent(animatedSprite);

        base.Start();
    }

    
    
}
