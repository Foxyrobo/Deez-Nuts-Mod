using System;
using System.Collections;
using System.Collections.Generic;
using Modding;
using UnityEngine;
using System.IO;
using Satchel.BetterMenus;

namespace Deez_Nuts_Mod
{
    public class Deez_Nuts_Mod : Mod, ICustomMenuMod
    {
        new public string GetName() => "Deez Nuts Mod";
        public override string GetVersion() => "1.0.0";

        public override void Initialize()
        {
            //Subscribe to language hook
            ModHooks.LanguageGetHook += LanguageGet;
        }

        public string LanguageGet(string key, string sheetTitle, string orig)
        {
            //Make everything "Deez Nuts"
            return "Deez Nuts";
        }

        public bool ToggleButtonInsideMenu => true;

        Menu MenuRef;
        public MenuScreen GetMenuScreen(MenuScreen modListMenu, ModToggleDelegates? toggleDelegates)
        {
            MenuRef ??= new Menu(
                name: "Deez Nuts Mod"
                );
            return MenuRef.GetMenuScreen(modListMenu);
        }
    }
}