using System;
using System.Collections;
using System.Collections.Generic;
using Modding;
using UnityEngine;
using System.IO;

namespace Deez_Nuts_Mod
{
    public class Deez_Nuts_Mod : Mod
    {
        new public string GetName() => "Deez Nuts Mod";
        public override string GetVersion() => "1.0.0";

        string textToSwap = "Deez Nuts";

        public override void Initialize()
        {
            //Subscribe to language hook
            ModHooks.LanguageGetHook += LanguageGet;
        }

        public string LanguageGet(string key, string sheetTitle, string orig)
        {
            //Make everything "Deez Nuts"
            return textToSwap;
        }
    }
}