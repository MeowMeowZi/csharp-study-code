using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LambdaDemo : MonoBehaviour
{
    List<string> names = new List<string>();

    private void Start()
    {
        names.Add("A1");
        names.Add("B1");
        names.Add("C1");
        names.Add("A2");
        names.Add("A3");
        names.Add("B2");

        foreach (var name in names)
        {
            Debug.Log(name);
        }

        var tempName = names.FindAll(s => s.StartsWith("A"));
        foreach (var i in tempName)
        {
            Debug.Log($"FindAll{i}");
        }

        names.RemoveAll(s => s.StartsWith("B"));
        
        foreach (var name in names)
        {
            Debug.Log(name);
        }
        // Find(names);
    }

    private void Find(List<string> names)
    {
        List<string> temp = new List<string>();
        foreach (var name1 in names)
        {
            if (name1.StartsWith("A"))
            {
                temp.Add(name1);
            }
        }

        foreach (var i in temp)
        {
            Debug.Log($"A -> {i}");
        }
    }
}
