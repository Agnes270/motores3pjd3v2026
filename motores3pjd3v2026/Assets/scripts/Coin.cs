using UnityEngine;

public class Coin : MonoBehaviour
{
    private bool foiColetada = false;

    private void Start()
    {
        Debug.LogWarning("========== COIN ESTÁ FUNCIONANDO ==========");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (foiColetada)
            return;

        Debug.LogWarning(
            "========== MOEDA TOCOU EM: " +
            other.name +
            " =========="
        );

        PlayerCoins playerCoins = other.GetComponent<PlayerCoins>();

        if (playerCoins != null)
        {
            foiColetada = true;

            Debug.LogWarning(
                "========== PLAYER COINS ENCONTRADO NO: " +
                playerCoins.gameObject.name +
                " =========="
            );

            playerCoins.CollectCoin();

            Destroy(gameObject);
        }
        else
        {
            Debug.LogWarning(
                "========== ESSE OBJETO NÃO TEM PLAYER COINS: " +
                other.name +
                " =========="
            );
        }
    }
}