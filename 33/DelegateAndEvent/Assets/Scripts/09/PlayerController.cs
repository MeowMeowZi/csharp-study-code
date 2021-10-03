using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public delegate void HPDelegate(int hp);

public delegate void MPDelegate(float mp);

public class PlayerController : MonoBehaviour
{
    public static PlayerController Instance;
    public event HPDelegate hpDelegate;
    public event MPDelegate mpDelegate;
    
    private int hp = 100;
    private float mp = 100f;

    public int HP
    {
        get { return hp; }
        set { hp = value; }
    }

    public float MP
    {
        get { return mp; }
        set { mp = value; }
    }

    private void Awake()
    {
        Instance = this;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            HP--;
            Debug.Log("HP: " + HP);
            if (hpDelegate != null) hpDelegate(HP);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            MP--;
            Debug.Log("MP: " + MP);
            if (mpDelegate != null) mpDelegate(MP);
        }
    }
}
