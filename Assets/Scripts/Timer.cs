using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] private float _startTimer;
    private float _mainTimer;
    private float _stepBetweenOutput = 1f;
    private float _currentTime = 0f;

    private float _loseTime;

    public float MainTimer => _mainTimer;
    public bool IsPlaying;

    private void Awake()
    {
        _mainTimer = _startTimer;
    }

    void Update()
    {
        if (IsPlaying)
            StartCounting();
    }

    public void StartCounting()
    {
        _currentTime += Time.deltaTime;
        if (_currentTime > _stepBetweenOutput)
        {
            _currentTime = 0f;
            _mainTimer -= _stepBetweenOutput;
            Debug.Log(_mainTimer);
        }
        if(_mainTimer <= 0f)
        {
            IsPlaying = false;
            _mainTimer = 0f;
        }
    }

    public void StopCounting()
    {
        IsPlaying = false;
    }
}
