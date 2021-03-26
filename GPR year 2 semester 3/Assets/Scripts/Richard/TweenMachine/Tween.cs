using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class Tween
{
    private GameObject _gameObject;
    private Vector3 _startPosition;
    private Vector3 _targetPosition;
    private Vector3 _direction;

    private float _speed;
    private float _percent;
    private bool _isFinished = false;

    private Func<float, float> EaseMethod;

    public Tween(GameObject objectToMove, Vector3 targetPosition, float speed, Func<float, float> easeMethod)
    {
        _gameObject = objectToMove;
        _targetPosition = targetPosition;
        _speed = speed;

        _startPosition = _gameObject.transform.position;
        _direction = _targetPosition - _startPosition;
        _percent = 0;

        EaseMethod = easeMethod;

        Debug.Log("Tween Started");
    }

    public void UpdateTween(float dt)
    {
        _percent += dt / _speed;

        if(_percent < 1)
        {
            float easeStep = EaseMethod(_percent);
            _gameObject.transform.position = _startPosition + (_direction * easeStep);
            Debug.Log(_gameObject + ": Tween Update");
        }
        else
        {
            _isFinished = true;
        }

    }
    public bool IsFinished()
    {
        return _isFinished;
    }
}
/*
IEnumerator Opdracht2(float duration)
{
Vector3 target = transform.position + Vector3.up * 3;
Vector3 startPosition = transform.position;
Vector3 direction = target - startPosition;
        
// percent is onze 'genormaliseerde' waarde tussen 0 en 1 
float percent = 0;
        
    while (percent < 1)
{
    // hier berekenen we op basis van tijd (en duratie) wat de volgende waarde van percent is.
    // 0 is het start punt, 1 het eind van de curve
    // percent verloopt dus eigenlijk altijd lineair ;)
    percent += Time.deltaTime / duration;
            
    // Vervolgens berekenen we op welke plek we van de curve moet zijn op basis van percent
    float easeStep = percent * percent * percent * percent * percent; // EaseInCubic
            
    // Hier kunnen we die waarde vervolgens toepassen op een parameter naar keuze
    transform.position = startPosition + (direction * easeStep);
            
    yield return null;
}
        
// Gezien we niet 100% controle hebben dat percent straks exact 1 is.
// moeten we hier de parameter welke we aanpassen hard toewijzen aan het gewenste eindresultaat.
transform.position = target;
}
*/