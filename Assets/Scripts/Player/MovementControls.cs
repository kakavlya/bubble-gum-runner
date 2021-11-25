using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementControls : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _flyingSpeed;

    private void Update()
    {
        ProcessActions();
    }

    private void ProcessActions()
    {
        //Vector3 movement = new Vector3(h, 0f, _movementSpeed);
        int horizontal = Mathf.RoundToInt(Input.GetAxis("Horizontal"));
        Vector3 movement = new Vector3(horizontal, _flyingSpeed, 0f);
        transform.Translate(movement * Time.deltaTime * _speed);
    }
}
