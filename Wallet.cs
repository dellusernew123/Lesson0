using UnityEngine;

public class Wallet : MonoBehaviour
{
    [SerializeField] private int _coinsToCollect = 5;
    private int _coins;
    public bool AllCoinsCollected { get; private set; } = false;

    public void TakeCoin()
    {
        _coins++;

        if (_coins >= _coinsToCollect)
            AllCoinsCollected = true;
    }
}
