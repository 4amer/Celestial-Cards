using System;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour, IInputManager
{
    private Dictionary<String, KeyInfo> keyByName = new Dictionary<String, KeyInfo>();

    private void Start()
    {
        SettingsData settingsData = SettingsData.Instance;
        foreach (String symbol in settingsData.avalebleInputSymbals)
        {
            AddInputKey(symbol);
        }
    }

    public KeyCode GetInput()
    {
        throw new NotImplementedException();
    }

    public bool IsInputKey(String controll)
    {
        if (Input.GetKey(keyByName[controll].keyCode)) return true;
        return false;
    }

    public bool IsInputKeyDown(String controll)
    {
        if (Input.GetKeyDown(keyByName[controll].keyCode)) return true;
        return false;
    }

    public bool IsInputKeyUp(String controll)
    {
        if (Input.GetKeyDown(keyByName[controll].keyCode)) return true;
        return false;
    }

    public void SetInputKey(String controll, String key2)
    {
        if (keyByName.TryGetValue(key2, out KeyInfo value))
        {
            Debug.LogError("The '" + key2 + "' key is already in use!");
            return;
        }
        KeyInfo keyInfo = new KeyInfo();
        keyInfo.keyCode = (KeyCode)System.Enum.Parse(typeof(KeyCode), key2);
        keyByName.Remove(controll);
        keyByName.Add(key2, keyInfo);
    }

    private void AddInputKey(String controll)
    {
        KeyInfo keyInfo = new KeyInfo();
        keyInfo.keyCode = (KeyCode)System.Enum.Parse(typeof(KeyCode), controll);
        keyByName.Add(controll, keyInfo);
    }
}
