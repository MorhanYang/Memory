using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PixelCrushers.DialogueSystem;

public class test : MonoBehaviour
{
    public int percent;
    public string percentage;

    public bool IslyingOver(int per)
    {
        return per > percent;
    }

     void OnEnable()
    {
        // Make the functions available to Lua: (Replace these lines with your own.)
        Lua.RegisterFunction("IslyingOver", this, SymbolExtensions.GetMethodInfo(() => IslyingOver((int) 0)));
    }

    void OnDisable()
    {
            // Remove the functions from Lua: (Replace these lines with your own.)
            Lua.UnregisterFunction("IslyingOver");
    }
}
