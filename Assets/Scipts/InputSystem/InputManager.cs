using System;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : IInputManager
{
    private Dictionary<String, KeyCode> keyByName = new Dictionary<String, KeyCode>();

    private void Start()
    {
        SettingsData settingsData = SettingsData.Instance;
        foreach (var data in settingsData.actionKeyData)
        {
            AddInputKey(data.action, data.keyCode);
        }
        Debug.Log(settingsData.actionKeyData.Length);
    }

    public override KeyCode GetInput()
    {
        throw new NotImplementedException();
    }

    public override bool IsInputKey(String action)
    {
        if (Input.GetKey(keyByName[action])) return true;
        return false;
    }

    public override bool IsInputKeyDown(String action)
    {
        if (Input.GetKeyDown(keyByName[action])) return true;
        return false;
    }

    public override bool IsInputKeyUp(String action)
    {
        if (Input.GetKeyDown(keyByName[action])) return true;
        return false;
    }

    public override void SetInputKey(String action, KeyCode key)
    {
        if (keyByName[action] == null)
        {
            Debug.LogError("The '" + action + "' is not defined!");
            return;
        }
        if (keyByName.ContainsValue(key))
        {
            Debug.LogError("The '" + key + "' key is already in use!");
            return;
        }
        keyByName.Remove(action);
        keyByName.Add(action, key);
    }

    private void AddInputKey(String action, KeyCode key)
    {
        keyByName.Add(action, key);
    }
}
