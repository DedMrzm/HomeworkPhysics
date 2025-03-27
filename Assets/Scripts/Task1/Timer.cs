using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] private float _startTimer;
    [SerializeField] private float _mainTimer;
    private float _stepBetweenOutput = 1f;
    private float _currentTime = 0f;

    private float _loseTime;
    private bool _isPlaying;

    public float MainTimer => _mainTimer;
    

    private void Awake()
    {
        _isPlaying = true;
        _mainTimer = _startTimer;
    }

    private void Update()
    {
        if (_isPlaying)
            StartCounting();
    }

    public void StartCounting()
    {
        _currentTime += Time.deltaTime;
        if (_currentTime >= _stepBetweenOutput)
        {
            _currentTime = 0f;
            _mainTimer -= _stepBetweenOutput;
            Debug.Log($"Timer: {_mainTimer}");
        }
        if(_mainTimer <= 0f)
        {
            _isPlaying = false;
            _mainTimer = 0f;
        }
    }

    public void StopCounting()
    {
        _isPlaying = false;
    }

    public void Restart()
    {
        _currentTime = 0;
        _isPlaying = true;
        _mainTimer = _startTimer;
    }
}
