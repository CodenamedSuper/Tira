using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tira;

public abstract class Entity : Body
{
    protected Entity(string id) : base(id)
    {
    }
}
