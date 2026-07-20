using UnityEngine;

public class PlayerCoins : MonoBehaviour
{
    public int coinCount = 0;

    private void OnEnable()
    {
        PlayerObserverManager.OnCoinCollected += CollectCoin;
    }

    private void OnDisable()
    {
        PlayerObserverManager.OnCoinCollected -= CollectCoin;
    }

    private void CollectCoin()
    {
        coinCount++;

        PlayerObserverManager.NotifyCoinCountChanged(coinCount);
    }
}