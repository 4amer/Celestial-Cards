using System;
using UnityEngine;

public interface IInputManager
{
    public KeyCode GetInput();
    public void SetInputKey(string key1, string key2);
    public bool IsInputKeyDown(string key);
    public bool IsInputKey(string key);
    public bool IsInputKeyUp(string key);
}
