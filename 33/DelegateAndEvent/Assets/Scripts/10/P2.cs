using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P2 : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            BiliBili.Instance.bilibiliDelegate += info =>
            {
                Debug.Log($"P2: 更新到第{info}集");
            };
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            BiliBili.Instance.bilibiliDelegate -= info =>
            {
                Debug.Log($"P2: 更新到第{info}集");
            };
        }
    }

    private void Show(string info)
    {
        Debug.Log($"P2: 更新到第{info}集");
    }
}