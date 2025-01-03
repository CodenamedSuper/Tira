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

        AnimatedSprite sprite = new AnimatedSprite("bit/" + Id.Name); AddComponent(sprite);
        sprite.AddAnimation("idle", new Animation(0, Main.WorldManager.World.TileSize, 3)); 
        SpawnTransformation spawnTransformation = new SpawnTransformation(); AddComponent(spawnTransformation);
        


        base.Start();
    }
}
