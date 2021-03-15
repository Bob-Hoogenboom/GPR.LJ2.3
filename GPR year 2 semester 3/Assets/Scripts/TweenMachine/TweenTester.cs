using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TweenTester : MonoBehaviour
{
    public Vector3 targetPosition;

    public float speed;

    public EasingType methodType;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            TweenMachine.GetInstance().MoveGameObject(gameObject, targetPosition, speed, methodType);
    }
}
