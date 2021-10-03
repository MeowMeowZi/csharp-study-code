using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace _08
{
    public delegate void EatDelegate();

    public class Master : MonoBehaviour
    {
        public static Master Instance;
        public event EatDelegate EatDelegate;

        private void Awake()
        {
            Instance = this;
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                ChiFan();
            }
        }

        private void ChiFan()
        {
            Debug.Log("到吃饭的时间啦");
            EatDelegate();
        }
    }
}