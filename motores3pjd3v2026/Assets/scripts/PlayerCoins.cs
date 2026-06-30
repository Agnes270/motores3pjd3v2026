using UnityEngine;

public class PlayerCoins : MonoBehaviour
{
    private int coinCount = 0;

    public void CollectCoin()
    {
        coinCount++;

        Debug.Log("Moeda coletada: " + coinCount);

        PlayerObserverManager.NotifyCoinCollected(coinCount);
    }
}