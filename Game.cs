using UnityEngine;

public class Game : MonoBehaviour
{
    [SerializeField] private GameObject _player;

    [SerializeField] private string _winMessage = "Вы выиграли! Вы собрали все монетки!";
    [SerializeField] private string _loseMessage = "Вы проиграли! Время истекло!";

    [SerializeField] private Timer _timer;
    [SerializeField] private Wallet _wallet;

    private bool _isStopped = false;

    private void Update()
    {
        if (_timer.TimeIsUp) 
            StopGame(isWin: false);

        if (_wallet.AllCoinsCollected) 
            StopGame(isWin: true);
    }
    
    public void StopGame(bool isWin)
    {
        if (_isStopped == false)
        {
            Debug.Log(isWin ? _winMessage : _loseMessage);
            _player.SetActive(false);
            _isStopped = true;
            _timer.Stop();
        }
    }
}
