using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tira;

public class Registries
{
    public static readonly Registry<Func<Tile>> TILES = new Registry<Func<Tile>>();
    public static readonly Registry<Func<Character>> CHARACTERS = new Registry<Func<Character>>();
    public static readonly Registry<Func<Action>> ACTIONS = new Registry<Func<Action>>();

}
