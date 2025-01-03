using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tira;

public class Creatures
{
    public static Dictionary<Id, Func<Creature>> List = new Dictionary<Id, Func<Creature>>();

    public static Func<Creature> Register(string name)
    {
        Func<Creature> creature = () => new Creature(name);
        List.Add(creature().Id, creature);

        return creature;

    }
}
