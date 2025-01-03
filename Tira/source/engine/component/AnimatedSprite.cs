using Microsoft.Xna.Framework;
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

    public int Frame { get; set; } = 0;

    private float currentSpeed;

    public AnimatedSprite(string path) : base(path)
    {
    }

    public void AddAnimation(string name, Animation animation)
    {
        animation.Name = name;
        Animations.Add(name, animation);

        if (Animations.Count == 1) SetAnimation(animation.Name);
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
        if(currentSpeed >= Animation.Speed)
        {
            Frame++;

            if(Frame >= Animation.Size)
            {
                Frame = 0;
            }

            currentSpeed = 0;
        }

        currentSpeed += 0.1f;
    }

    public override void Draw()
    {
        Main.SpriteBatch.Draw(texture2d, Parent.Position + Offset, new Rectangle((int)Animation.Frames[Frame].X, (int)Animation.Frames[Frame].Y, (int)Animation.TileSize.X, texture2d.Height / (int)Animation.Size), Color, Parent.Rotation, new Vector2(Animation.TileSize.X / 2, Animation.TileSize.Y / 2), Parent.Scale, Effect, (Parent.Layer + LayerOffset) * 0.001f);
    }
}
