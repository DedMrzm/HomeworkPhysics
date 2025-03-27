using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformController : MonoBehaviour
{
    private string HorizontalAxis = "Horizontal";
    private string VerticalAxis = "Vertical";

    private float _xInput;
    private float _zInput;

    private float _deadZone = 0.05f;

    private Rigidbody _rigidbody;

    [SerializeField] private float _rotationSpeed;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        HandleInput();
    }

    private void FixedUpdate()
    {
        HandleRotate();
    }

    private void HandleInput()
    {
        _xInput = Input.GetAxis(HorizontalAxis);
        _zInput = Input.GetAxis(VerticalAxis);
    }

    private void HandleRotate()
    {
        if (Mathf.Abs(_xInput) > _deadZone)
        {
            transform.Rotate(-Vector3.forward * _xInput * _rotationSpeed * Time.deltaTime);
            Debug.Log("RIGHT-LEFT");
        }

        if (Mathf.Abs(_zInput) > _deadZone)
        {
            transform.Rotate(Vector3.right * _zInput * _rotationSpeed * Time.deltaTime);
            Debug.Log("RIGHT-LEFT");
        }
    }
}
