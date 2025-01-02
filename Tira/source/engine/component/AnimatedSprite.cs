using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tira;

public class AnimatedSprite : Sprite
{
    public Dictionary<string, Animation> Animations { get; set; } = new Dictionary<string, Animation>();

    public Animation Animation { get; set; }

    public AnimatedSprite(string path) : base(path)
    {
    }

    public void AddAnimation(string name, Animation animation)
    {
        animation.Name = name;
        Animations.Add(name, animation);
    }

    public void SetAnimation(string name)
    {
        Animation = Animations[name];
    }



    public override void Update()
    {
        Animate();

        base.Update();
    }

    public void Animate()
    {

    }
}
