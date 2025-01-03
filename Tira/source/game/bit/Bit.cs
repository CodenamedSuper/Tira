using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tira;

public class Bit : Entity
{
    public Bit(string name)
    {
        Id.Name = name;
    }
    public override void Start()
    {
        Layer = 2;

        Sprite sprite = new Sprite("bit/" + Id.Name); AddComponent(sprite);
        SpawnTransformation spawnTransformation = new SpawnTransformation(); AddComponent(spawnTransformation);
        


        base.Start();
    }
}
