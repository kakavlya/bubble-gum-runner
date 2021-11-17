using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    [SerializeField] private float _tapForce;
    [SerializeField] private Vector3 _startPosition;


    private Rigidbody _body;
    private Quaternion _rotation;

    private void Start()
    {
        _body = GetComponent<Rigidbody>();
        _rotation = new Quaternion(0f, 0f, 0f, 0f);
        _body.velocity = Vector3.zero;
        Reset();
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            _body.AddForce(Vector3.up * _tapForce, ForceMode.Force);
        }
    }

    public void Reset()
    {
        _body.transform.position = _startPosition;
        //_body.transform.rotation = _rotation;
        //_body.constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionX;
        //_animator.SetBool(IsDeadConst, false);
    }

    public void Die()
    {
        // TODO
        //_animator.SetBool(IsDeadConst, true);
    }
}
