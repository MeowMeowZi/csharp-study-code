using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QQUser : MonoBehaviour
{
    private void Start()
    {
        // QQGroup.Instance.logicDelegate += LogicFunc;
        // QQGroup.Instance.messageDelegate += MessageFunc;
        QQGroup.Instance.logicDelegate += delegate(string name)
        {
            Debug.Log($"{name}已上线~~");
        };
        QQGroup.Instance.messageDelegate += delegate(string name, string message)
        {
            Debug.Log($"{name}说: {message}~~");
        };
    }

    private void LogicFunc(string name)
    {
        Debug.Log($"{name}已上线");
    }

    private void MessageFunc(string name, string message)
    {
        Debug.Log($"{name}说: {message}");
    }
}
