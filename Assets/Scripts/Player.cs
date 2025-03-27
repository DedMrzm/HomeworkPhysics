using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private string HorizontalAxis = "Horizontal";
    private string VerticalAxis = "Vertical";

    private KeyCode JumpCode = KeyCode.Space;

    private Rigidbody _rigidbody;

    [SerializeField] private float _speed;
    [SerializeField] private float _jumpForce;

    private int _wallet;

    private float _xInput;
    private float _zInput;

    private float _deadZone = 0.05f;

    // Start is called before the first frame update
    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private void Update()
    {
        InputHandler();
    }

    private void FixedUpdate()
    {
        MoveHandler();
    }

    private void Jump()
    {
        _rigidbody.AddForce(Vector3.up * _jumpForce, ForceMode.Impulse);
    }

    private void MoveHandler()
    {
        if (Mathf.Abs(_xInput) > _deadZone)
            _rigidbody.AddForce(Vector3.right * _speed * _xInput);
        if (Mathf.Abs(_zInput) > _deadZone)
            _rigidbody.AddForce(Vector3.forward * _speed * _zInput);
    }

    private void InputHandler()
    {
        _xInput = Input.GetAxis(HorizontalAxis);
        _zInput = Input.GetAxis(VerticalAxis);

        if(Input.GetKeyDown(JumpCode))
            Jump();
    }

    public void TakeCoin()
    {

    }
}
