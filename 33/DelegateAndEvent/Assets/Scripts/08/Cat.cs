using System;
using System.Collections;
using System.Collections.Generic;
using _08;
using UnityEngine;

public class Cat : MonoBehaviour
{
    private void Start()
    {
        Master.Instance.EatDelegate += CatEat;
    }

    private void CatEat()
    {
        Debug.Log("吃饭啦！喵喵喵！");
    }
}
