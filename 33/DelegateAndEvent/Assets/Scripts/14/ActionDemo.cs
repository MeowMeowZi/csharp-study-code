using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public delegate void MeowDelegate();

public class ActionDemo : MonoBehaviour
{
    private MeowDelegate _meowDelegate;
    private Action _nameDelegate;
    private Action<int, int> _calc;

    private void Start()
    {
        _meowDelegate = () => Debug.Log("Meow");
        _meowDelegate += () => Debug.Log("MeowMeowZi");
        if (_meowDelegate != null) _meowDelegate();

        _nameDelegate = () => Debug.Log("DD");
        _nameDelegate();

        _calc = (a, b) => Debug.Log($"{a} + {b} = {a + b}");
        _calc += (a, b) => Debug.Log($"{a} * {b} = {a * b}");
        _calc(2, 3);
    }
}
