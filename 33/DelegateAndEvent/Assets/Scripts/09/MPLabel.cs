using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MPLabel : MonoBehaviour
{
    private Transform _transform;
    private UILabel _uiLabel;

    private void Start()
    {
        _transform = GetComponent<Transform>();
        _uiLabel = _transform.Find("Label").GetComponent<UILabel>();
        PlayerController.Instance.mpDelegate += UpdateMP;
    }

    private void UpdateMP(float mp)
    {
        _uiLabel.text = mp.ToString();
    }
}
