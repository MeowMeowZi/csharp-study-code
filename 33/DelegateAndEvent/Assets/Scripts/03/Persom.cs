using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Persom<T>
{
    public string name;
    public int age;
    public T info;

    public void ShowInfo()
    {
        Debug.Log($"{name} -- {age} -- {info}");
    }

    public T GetInfo()
    {
        return info;
    }
}
