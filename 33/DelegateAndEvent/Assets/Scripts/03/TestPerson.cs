using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestPerson : MonoBehaviour
{
    void Start()
    {
        var p = new Persom<string>();
        p.name = "Meow";
        p.age = 17;
        p.info = "ShangHai";
        p.ShowInfo();

        var p2 = new Persom<float>();
        p2.name = "DD";
        p2.age = 21;
        p2.info = 3.14f;
        p2.ShowInfo();
        
        Debug.Log(p.GetInfo());
        
        Debug.Log(Meow<string>("Meow"));
        Debug.Log(Meow(3.14f));
    }

    public T Meow<T>(T name)
    {
        return name;
    }
}
