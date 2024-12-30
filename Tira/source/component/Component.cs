using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tira;

public abstract class Component
{
    public Entity Parent { get; set; }
    public Component()
    {

    }

    public virtual void Start()
    {

    }

    public void SetParent(Entity parent)
    {
        Parent = parent;
    }

    public T GetSibling<T>() where T : Component
    {
        return Parent.Components.FirstOrDefault(component => component is T) as T;

    }

    public virtual void Update()
    {

    }

    public virtual void Draw()
    {

    }
}
