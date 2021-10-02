using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 委托.
/// </summary>
public delegate void WebDelegate();

public class WebInfo : MonoBehaviour
{
    private void Start()
    {
        // MyWeb(BaiDu);
        // MyWeb(BiliBili);
        // MyWeb(WeiBo);

        WebDelegate webDelegate = BaiDu;
        webDelegate += BiliBili;
        webDelegate += WeiBo;
        webDelegate();
        Debug.Log("--------------------");
        webDelegate -= BaiDu;
        webDelegate();
        Debug.Log("--------------------");
    }

    private void MyWeb(WebDelegate webDelegate)
    {
        webDelegate();
    }
    
    private void BaiDu()
    {
        Debug.Log("BaiDu");
    }

    private void BiliBili()
    {
        Debug.Log("BiliBili");
    }

    private void WeiBo()
    {
        Debug.Log("WeoBo");
    }
}
