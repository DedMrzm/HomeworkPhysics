using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Timer _timer;
    [SerializeField] private Player _player;
    private int _coinsToWin;



    private void Update()
    {
        if (_player.CoinsInWallet >= _coinsToWin)
            Win();
        else if (_timer.MainTimer <= 0)
            Lose();
    }

    private void Win()
    {
        _timer.IsPlaying = false;
        _player.GetComponent<Rigidbody>().velocity = Vector3.zero;
        Debug.Log("Congratilations, You Win!");
    }

    private void Lose()
    {
        _timer.IsPlaying = false;
        _player.gameObject.SetActive(false);
        Debug.Log("You lose!");
    }
}
