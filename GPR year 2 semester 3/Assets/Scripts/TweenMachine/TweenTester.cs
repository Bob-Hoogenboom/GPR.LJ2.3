using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TweenTester : MonoBehaviour
{
    public Vector3 targetPosition;

    public float speed;

    public EasingType methodType; // gebruikt de enum list


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
            TweenMachine.GetInstance().MoveGameObject(gameObject, targetPosition, speed, methodType);
        
        /*else if (Input.GetKeyDown(KeyCode.Alpha2))
            TweenMachine.GetInstance().RotateGameObject(gameObject, speed, methodType);*/
    }
}
