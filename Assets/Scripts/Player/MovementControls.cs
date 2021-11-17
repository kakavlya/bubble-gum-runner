using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementControls : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void Update()
    {
        ProcessActions();
    }

    private void ProcessActions()
    {
        int horizontal = Mathf.RoundToInt(Input.GetAxis("Horizontal"));
        Vector3 movement = new Vector3(horizontal, 0f, 0f);
        transform.Translate(movement * Time.deltaTime * _speed);
    }
}
