using System;
using UnityEngine;

public abstract class IInputManager: MonoBehaviour
{
    public abstract KeyCode GetInput();
    public abstract void SetInputKey(string actinon, KeyCode key);
    public abstract bool IsInputKeyDown(string actinon);
    public abstract bool IsInputKey(string actinon);
    public abstract bool IsInputKeyUp(string actinon);
}
