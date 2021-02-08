using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coroutine : MonoBehaviour
{
    [SerializeField] float _Seconds = 0.5f;


    void Start()
    {
        StartCoroutine(Routine());
    }

    IEnumerator Routine()
    {
        Debug.Log("Ik start nu de coroutine");
        yield return new WaitForSeconds(_Seconds);
        for (float i = 9; i >= 0; i-- )
        {
        Debug.Log("Coroutine update");
        yield return new WaitForSeconds(_Seconds);
        }

        Debug.Log("Coroutine einde");
    }
}


