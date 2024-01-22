using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private int _maxHP;
    [SerializeField] private int _currentHP;
    [SerializeField] private int _speed;

    [SerializeField] private IInputManager _inputManager;

    void Start()
    {
        
    }

    void Update()
    {
        Input();
    }

    private void Shoot()
    {

    }

    private void DoSpellAttack()
    {

    }

    private void Input()
    {
        if (_inputManager.IsInputKey("Up"))
        {
            Debug.Log("Lololololo");
        }
    }
}
