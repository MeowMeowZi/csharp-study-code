using System;using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuncDemo : MonoBehaviour
{
    private Func<int> _func;
    private Func<int, int, int> _calc;

    private void Start()
    {
        // _func = () => 520;
        _func = () =>
        {
            Debug.Log("Meow");
            return 666;
        };
        Debug.Log(_func());

        _calc = (a, b) => a + b;

        Debug.Log(_calc(5, 10));
    }
}
