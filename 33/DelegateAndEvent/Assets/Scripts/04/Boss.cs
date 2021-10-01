using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Boss: " + MapManager.Instance.count);
            Debug.Log("Boss: " + XMLManager.Instance.name);
        }
    }
}
