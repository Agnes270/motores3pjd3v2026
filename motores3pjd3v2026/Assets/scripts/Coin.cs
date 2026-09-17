using UnityEngine;

public class Coin : MonoBehaviour
{
    private void Start()
    {
        Debug.LogWarning("========== COIN ESTÁ FUNCIONANDO ==========");
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.LogWarning("========== MOEDA TOCOU EM: " + other.name + " ==========");

        PlayerCoins playerCoins = other.GetComponent<PlayerCoins>();

        if (playerCoins != null)
        {
            Debug.LogWarning(
                "========== PLAYER COINS ENCONTRADO NO: " +
                playerCoins.gameObject.name + " =========="
            );

            playerCoins.CollectCoin();

            Destroy(gameObject);
        }
        else
        {
            Debug.LogWarning(
                "========== ESSE OBJETO NÃO TEM PLAYER COINS: " +
                other.name + " =========="
            );
        }
    }
}