using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public delegate void BiliBiliDelegate(string info);

public class BiliBili : MonoBehaviour
{
    public static BiliBili Instance;
    public BiliBiliDelegate bilibiliDelegate;

    public int Index { get; set; } = 0;

    private void Awake()
    {
        Instance = this;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Index++;
            Debug.Log($"更新到第{Index}集");
            if (bilibiliDelegate != null) bilibiliDelegate(Index.ToString());
            // bilibiliDelegate(Index.ToString());
        }
    }
}
