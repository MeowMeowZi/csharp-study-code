using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Player: " + MapManager.Instance.count);
        MapManager.Instance.count = 100;

        Debug.Log("Player: " + XMLManager.Instance.name);
        XMLManager.Instance.name = "DD";
    }
}
