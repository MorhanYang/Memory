using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PixelCrushers.DialogueSystem;

public class functest : MonoBehaviour
{
    // Start is called before the first frame update
    public string currentGarment = "ribe";
    public int xp;

    public bool Is(string requiredGarment)
    {
        return currentGarment ==requiredGarment;
    }
    public void GiveXP(double amount)
    {
        xp += (int) amount;
    }

    void OnEnable()
    {
        // Make the functions available to Lua: (Replace these lines with your own.)
        Lua.RegisterFunction("Is", this, SymbolExtensions.GetMethodInfo(() => Is(string.Empty)));
         Lua.RegisterFunction("GiveXP", this, SymbolExtensions.GetMethodInfo(() => GiveXP((double)0)));
        
    }

    void OnDisable()
    {
            // Remove the functions from Lua: (Replace these lines with your own.)
            Lua.UnregisterFunction("Is");
            Lua.UnregisterFunction("GiveXP");
    }
}
