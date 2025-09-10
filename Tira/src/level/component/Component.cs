using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tira;

public class Component
{
    public Body Parent { get; set; }

    public virtual void Start()
    {

    }
    public virtual void Update()
    {

    }
    public virtual void Draw()
    {

    }
}
