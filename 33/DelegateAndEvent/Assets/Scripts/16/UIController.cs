using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour
{
    private GameObject _startButton;

    private void Start()
    {
        _startButton = GameObject.Find("StartButton");
        UIEventListener.Get(_startButton).onClick += StartButtonEvent;
        UIEventListener.Get(_startButton).onClick += go => Debug.Log("Lambda表达式...");
    }

    private void StartButtonEvent(GameObject go)
    {
        Debug.Log($"{go.name}: 我被点击啦！");
    }
}