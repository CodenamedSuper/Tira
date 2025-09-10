using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tira;

public class Body
{
    public string ID { get; set; } = string.Empty;
    public List<Component> Components { get; set; } = new List<Component>();
    public Body(string id)
    {
        ID = id;
    }
    public virtual void Start()
    {

    }
    public void Add(Component component)
    {
        component.Parent = this;
        component.Start();
        Components.Add(component);
    }
    public T Get<T>() where T : Component
    {
        return Components.FirstOrDefault(component => component is T) as T;
    }
    public bool Has<T>() where T : Component
    {
        foreach (Component component in Components)
        {
            if (component is T) return true;
        }

        return false;
    }
    public Component Remove(Component component)
    {
        Components.Remove(component);

        return component;
    }
    public virtual void Update()
    {
        Components.ForEach(component => component.Update());
    }
    public virtual void Draw()
    {
        Components.ForEach(component => component.Draw());
    }
}
