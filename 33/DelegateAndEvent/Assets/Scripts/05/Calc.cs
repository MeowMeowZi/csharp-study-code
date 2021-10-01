using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 计算器四则运算委托.
/// </summary>
public delegate void CalcDelegate(int a, int b);

/// <summary>
/// 计算器脚本.
/// </summary>
public class Calc : MonoBehaviour
{
    private void Start()
    {
        var numA = 10;
        var numB = 2;

        // JiaFa(numA, numB);
        // JianFa(numA, numB);
        // ChengFa(numA, numB);
        // ChuFa(numA, numB);

        MyCalc(numA, numB, JiaFa);
        MyCalc(numA, numB, JianFa);
        MyCalc(numA, numB, ChengFa);
        MyCalc(numA, numB, ChuFa);
    }

    private void MyCalc(int a, int b, CalcDelegate calcDel)
    {
        calcDel(a, b);
    }
    
    private void JiaFa(int a, int b)
    {
        Debug.Log($"{a} + {b} = {a+b}");
    }
    
    private void JianFa(int a, int b)
    {
        Debug.Log($"{a} - {b} = {a-b}");
    }
    
    private void ChengFa(int a, int b)
    {
        Debug.Log($"{a} * {b} = {a*b}");
    }
    
    private void ChuFa(int a, int b)
    {
        Debug.Log($"{a} / {b} = {a/b}");
    }
    
}
