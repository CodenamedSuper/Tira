using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tira;

public class Characters
{
    public static readonly Func<Character> KING = Register(() => new King("king"));

    public static Func<Character> Register(Func<Character> character)
    {
        Registries.CHARACTERS.Register(character().ID, character);

        return character;
    }
}
