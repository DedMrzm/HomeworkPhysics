using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowTarget : MonoBehaviour
{
    [SerializeField] private Transform _target;

    [SerializeField] private Vector3 _offset;

    private void Awake()
    {
        if(_offset == Vector3.zero)
            _offset = transform.position;
    }

    private void Update()
    {
        transform.position = _target.position + _offset;
    }
}
