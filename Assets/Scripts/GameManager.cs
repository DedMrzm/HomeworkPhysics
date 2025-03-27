using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Timer _timer;
    [SerializeField] private Player _player;

    private KeyCode RestartKey = KeyCode.R;

    [SerializeField] private int _coinsToWin;

    [SerializeField] private List<Coin> _coins;

    private void Start()
    {
        Debug.Log($"Start Game:\nTimer: {_timer.MainTimer}\nCoins in Wallet: {_player.CoinsInWallet}");
    }

    private void Update()
    {
        HandleEndOfTheGame();
        if (Input.GetKeyDown(RestartKey))
            Restart();
    }

    private void Win()
    {
        StopGame();

        Debug.Log("Congratilations, You Win!");
    }

    private void Lose()
    {
        StopGame();
        _player.gameObject.SetActive(false);

        Debug.Log("You lose!");
    }

    private void StopGame()
    {
        _timer.StartCounting();
        _player.Stop();
    }

    private void Restart()
    {
        _timer.Restart();
        _player.Restart();
        Debug.Log($"RESTART:\nTimer: {_timer.MainTimer}\nCoins in Wallet: {_player.CoinsInWallet}");

        foreach (Coin coin in _coins)
        {
            coin.gameObject.SetActive(true);
        }
    }

    private void HandleEndOfTheGame()
    {
        if (_player.CoinsInWallet >= _coinsToWin)
            Win();
        else if (_timer.MainTimer <= 0)
            Lose();
    }
}
