using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TwoPointsMover : MonoBehaviour
{
    [SerializeField] private GameObject _pointAObj;
    [SerializeField] private GameObject _pointBObj;
    [SerializeField] private float _speed;

    private Vector3 _pointA;
    private Vector3 _pointB;

    private float _startTime;
    private float _journeyLength;

    private void Start()
    {
        _pointA = _pointAObj.transform.position;
        _pointB = _pointBObj.transform.position;
        _journeyLength = Vector3.Distance(_pointA, _pointB);
        _startTime = Time.time;
    }

    private void Update()
    {
        //float distCovered = (Time.time - _startTime) * _speed;
        //float fractionOfJourney = distCovered / _journeyLength;
        //transform.position = Vector3.Lerp(_pointA, _pointB, fractionOfJourney);
        transform.position = Vector3.Lerp(_pointA, _pointB, Mathf.PingPong(Time.time, 1));
    }
}
