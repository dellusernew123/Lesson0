using UnityEngine;

public class CoinCounter : MonoBehaviour
{
    private Wallet _wallet;

    private void Start()
    {
        _wallet = GetComponent<Wallet>();
    }

    private void OnTriggerEnter(Collider other)
    {
        Coin coin = other.GetComponent<Coin>();

        if (coin != null)
        {
            _wallet.TakeCoin();
            coin.gameObject.SetActive(false);
        }
    }
}
