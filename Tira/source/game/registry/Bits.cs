using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tira;

public class Bits
{
    public static Dictionary<Id, Func<Bit>> List = new Dictionary<Id, Func<Bit>>();

    public static readonly Func<Bit> TREE = Register("tree");

    public static Func<Bit> Register(string name)
    {
        Func<Bit> bit = () => new Bit(name);
        List.Add(bit().Id, bit);

        return bit;

    }
}
