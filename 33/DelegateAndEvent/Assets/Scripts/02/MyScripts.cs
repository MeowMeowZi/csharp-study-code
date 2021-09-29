using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyScripts : MonoBehaviour
{
    void Start()
    {
        Debug.Log("AAA");

        var m = new Meow();
        m.Hello();
        
        GameObject.Destroy(gameObject);
        // GameObject.Destroy(this);
    }

    void Update()
    {
        
    }
}
