using UnityEngine;

public class PlayerCoins : MonoBehaviour
{
    public int coinCount = 0;

    public void CollectCoin()
    {
        coinCount++;

        PlayerObserverManager.NotifyCoinCollected();         
        PlayerObserverManager.NotifyCoinCountChanged(coinCount); 
    }
}