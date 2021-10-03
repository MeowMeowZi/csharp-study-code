using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P3 : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            BiliBili.Instance.bilibiliDelegate += Show;
        }

        if (Input.GetKeyDown(KeyCode.X))
        {
            BiliBili.Instance.bilibiliDelegate -= Show;
        }
    }

    private void Show(string info)
    {
        Debug.Log($"P3: 更新到第{info}集");
    }
}