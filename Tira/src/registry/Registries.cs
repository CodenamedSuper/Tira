using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tira;

public class Registries
{
    public static readonly Registry<Func<Tile>> TILES = new Registry<Func<Tile>>(); 
}
