using System;
using System.Collections;
using System.Collections.Generic;
using _08;
using UnityEngine;

public class Dog : MonoBehaviour
{
    private void Start()
    {
        Master.Instance.EatDelegate += DogEat;
    }

    private void DogEat()
    {
        Debug.Log("吃饭啦！汪汪汪！");
    }
}
