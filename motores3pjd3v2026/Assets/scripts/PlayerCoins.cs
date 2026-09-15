using UnityEngine;

public class PlayerCoins : MonoBehaviour
{
    [SerializeField] private int playerIndex = 1;

    private int coinCount = 0;
    private int estrelaCount = 0;

    public void CollectCoin()
    {
        coinCount++;

        Player player = GetComponent<Player>();

        if (player != null)
        {
            player.AumentarVelocidade();
        }

        PlayerObserverManager.NotifyCoinCountChanged(playerIndex, coinCount);

        Debug.Log("Jogador " + playerIndex + " - Moedas: " + coinCount);
    }

    public void ColetarEstrela()
    {
        estrelaCount++;

        Debug.Log("⭐ Jogador " + playerIndex + " - Estrelas: " + estrelaCount);
    }
}