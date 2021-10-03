using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPLabel : MonoBehaviour
{
    private Transform _transform;
    private UILabel _hpLabel;

    private void Start()
    {
        _transform = GetComponent<Transform>();
        _hpLabel = _transform.Find("Label").GetComponent<UILabel>();
        PlayerController.Instance.hpDelegate += UpdateHP;
    }

    private void UpdateHP(int hp)
    {
        _hpLabel.text = hp.ToString();
    }
}
