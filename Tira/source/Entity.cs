using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tira;

public class Entity
{
    public string Name { get; set; } = "";
    public Vector2 Position { get; set; } = Vector2.Zero;

    public Vector2 Dimensions { get; set; } = Vector2.Zero;

    public float Rotation { get; set; } = 0;

    public float Scale = 0;

    public List<Component> Components { get; set; } = new List<Component>();
    public virtual void Start()
    {

    }

    public void AddComponent(Component component)
    {
        Components.Add(component);
    }

    public void RemoveComponent(Component component)
    {
        Components.Remove(component);
    }

    public T GetComponent<T>() where T : Component
    {
        return Components.FirstOrDefault(component => component is T) as T;

    }

    public virtual void Update()
    {
        foreach (Component component in Components)
        {
            component.Update();
        }
    }

    public virtual void Draw()
    {
        foreach (Component component in Components)
        {
            component.Draw();
        }
    }
}
