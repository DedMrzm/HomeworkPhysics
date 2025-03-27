using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    private int _leftSide = -1;
    private int _rightSide = 1;

    [SerializeField] private float _rotationSpeed = 40f;

    private int _currentSide = 0;

    private void Awake()
    {
        _currentSide = ChooseSideOfRotation();
    }

    private int ChooseSideOfRotation()
    {
        int chance = Random.Range(0, 2);

        return chance == 0 ? _leftSide : _rightSide;
    }

    private void Update()
    {
        transform.Rotate(_currentSide * _rotationSpeed * Vector3.up * Time.deltaTime);
    }
}
