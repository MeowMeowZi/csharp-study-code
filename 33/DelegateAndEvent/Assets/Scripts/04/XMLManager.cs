using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XMLManager
{
    public string name = "Meow";
    
    private static XMLManager instance;

    private XMLManager()
    {
            
    }

    public static XMLManager Instance => instance ?? new XMLManager();
}
