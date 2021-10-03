using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.VersionControl;
using UnityEngine;

public delegate void LogicDelegate(string name);

public delegate void MessageDelegate(string name, string message);

public class QQGroup : MonoBehaviour
{
    public static QQGroup Instance;
    public event LogicDelegate logicDelegate;
    public event MessageDelegate messageDelegate;
    
    private void Awake()
    {
        Instance = this;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            if (logicDelegate != null) logicDelegate("Meow");
        }
        
        if (Input.GetKeyDown(KeyCode.D))
        {
            if (messageDelegate != null) messageDelegate("Meow", "Hello");
        }
    }
}
