using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public delegate void LambdaDelegate();

public delegate void LambdaDelegate_2(string name);

public delegate void LambdaDelegate_3(string name, int age);

public class LambdaTest : MonoBehaviour
{
    public event LambdaDelegate lambdaDelegate;
    public event LambdaDelegate_2 lambdaDelegate_2;
    public event LambdaDelegate_3 lambdaDelegate_3;

    private void Start()
    {
        lambdaDelegate = TestFunc;
        lambdaDelegate += delegate
        {
            Debug.Log("delegate~");
        };
        lambdaDelegate += () =>
        {
            Debug.Log("()");
        };

        lambdaDelegate_2 = name =>
        {
            Debug.Log("一个参数的lambda" + name);
        };

        lambdaDelegate_3 = (name, age) =>
        {
            Debug.Log("两个参数的lambda" + name + age);
        };

        if (lambdaDelegate != null) lambdaDelegate();
        if (lambdaDelegate_2 != null) lambdaDelegate_2("Meow");
        if (lambdaDelegate_3 != null) lambdaDelegate_3("Meow", 17);
    }

    public void TestFunc()
    {
        Debug.Log("TestFunc");
    }
}
