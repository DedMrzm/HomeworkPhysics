using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] private int _minValue;
    [SerializeField] private int _maxValue;

    private int _currentValue;

    public int CurrentValue => _currentValue;

    private void Awake()
    {
        _currentValue = GenerateValue();
    }

    private int GenerateValue()
    {
        return Random.Range(_minValue, _maxValue);
    }

    private void OnTriggerEnter(Collider other)
    {
        Coin coin = other.GetComponent<Coin>();

        if (coin != null)
        {

        }
    }
}
