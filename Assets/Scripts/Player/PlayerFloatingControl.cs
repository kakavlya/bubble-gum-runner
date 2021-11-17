using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFloatingControl : MonoBehaviour
{
    [SerializeField] private float _floatStrength;

    private Rigidbody _body;

    private void Start()
    {
        _body = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        //_body.AddForce(Vector3.up * _floatStrength);
    }
}
