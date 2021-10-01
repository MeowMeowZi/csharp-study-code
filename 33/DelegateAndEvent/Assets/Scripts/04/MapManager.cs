using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapManager : MonoBehaviour
{
    public static MapManager Instance;
    public int count = 0;

    void Awake()
    {
        Instance = this;
    }
}
