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

        PlayerCoins playerCoins = other.GetComponentInParent<PlayerCoins>();

        if (playerCoins != null)
        {
            Debug.LogWarning("========== PLAYERCOINS ENCONTRADO ==========");

            playerCoins.CollectCoin();

            Destroy(gameObject);
        }
    }
}