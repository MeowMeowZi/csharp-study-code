using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P1 : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            BiliBili.Instance.bilibiliDelegate += delegate(string info)
            {
                Debug.Log($"P1: 更新到第{info}集");
            };
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            BiliBili.Instance.bilibiliDelegate -= delegate(string info)
            {
                Debug.Log($"P1: 更新到第{info}集");
            };
        }
    }

    private void Show(string info)
    {
        Debug.Log($"P1: 更新到第{info}集");
    }
}
