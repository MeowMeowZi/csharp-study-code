using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Android委托.
/// </summary>
public delegate int AndroidDelegate(string name);

/// <summary>
/// IOS委托.
/// </summary>
public delegate string IOSDelegate(int price);

/// <summary>
/// 描述不同版本系统.
/// </summary>
public class Phone : MonoBehaviour
{
    private void Start()
    {
        MyAndroid("小米", Android5);
        MyAndroid("华为", Android6); 
        MyIOS(5999, IOS5);
        MyIOS(8999, IOS6);
    }

    private void MyAndroid(string name, AndroidDelegate androidDelegate)
    {
        androidDelegate(name);
    }

    private void MyIOS(int price, IOSDelegate iosDelegate)
    {
         Debug.Log(iosDelegate(price));
    }
    
    private int Android5(string name)
    {
        Debug.Log("Android5 -- " + name);
        return 5;
    }

    private int Android6(string name)
    {
        Debug.Log("Android6 -- " + name);
        return 6;
    }

    private string IOS5(int price)
    {
        return $"IOS5 -- {price}";
    }

    private string IOS6(int price)
    {
        return "IOS6 -- " + price;
    }
}
