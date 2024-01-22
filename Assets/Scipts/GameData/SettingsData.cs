using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class SettingsData
{
    // Input
    [SerializeField] public ActionKeyInfo[] actionKeyData =
    {
        new ActionKeyInfo(){action = "Up", keyCode = KeyCode.W}
    };

    private static SettingsData settingsData;

    private SettingsData() { }

    public static SettingsData Instance 
    { 
        get
        {
            if(settingsData == null) settingsData = new SettingsData();
            return settingsData;
        }
    }
}
