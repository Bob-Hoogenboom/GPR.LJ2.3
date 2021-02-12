﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coroutine : MonoBehaviour
{
    [SerializeField] float _Seconds = 0.5f;
    [SerializeField] Renderer _renderer;

    void Start()
    {
        _renderer = GetComponent<Renderer>();
    }

    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            StartCoroutine(Routine());
        }
    }

    IEnumerator Routine()
    {
        Debug.Log("Ik start nu de coroutine");
        for (float i = 1; i >= 0; i-= 0.01f)
        {
            Color c = _renderer.material.color;
            c.a = i;
            _renderer.material.color = c;
            Debug.Log("fade");
            yield return new WaitForSeconds(_Seconds / 100);
        }

        Debug.Log("Coroutine einde");
    }
}


