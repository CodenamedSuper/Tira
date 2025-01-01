using System.Collections.Generic;
using Microsoft.Xna.Framework.Input;

namespace Tira;
public class TiraKeyboard
{
    private KeyboardState newKeyboard, oldKeyboard;
    private List<TiraKey> pressedKeys = new List<TiraKey>(), previousPressedKeys = new List<TiraKey>();

    public void Update()
    {
        newKeyboard = Keyboard.GetState();

        GetPressedKeys();

        oldKeyboard = newKeyboard;

        previousPressedKeys = new List<TiraKey>();

        for (int i = 0; i < pressedKeys.Count; i++)
        {
            previousPressedKeys.Add(pressedKeys[i]);
        }
    }

    public bool GetKeyPress(string KEY)
    {
        for (int i = 0; i < pressedKeys.Count; i++)
        {
            if (pressedKeys[i].key == KEY)
            {
                return true;
            }
        }

        return false;
    }

    public void GetPressedKeys()
    {
        bool found = false;

        pressedKeys.Clear();

        for (int i = 0; i < newKeyboard.GetPressedKeys().Length; i++)
        {
            pressedKeys.Add(new TiraKey(newKeyboard.GetPressedKeys()[i].ToString(), 1));
        }
    }

}