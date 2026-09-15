using UnityEngine;

public class Estrela : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player"))
            return;

        PlayerCoins playerCoins = other.GetComponentInParent<PlayerCoins>();

        if (playerCoins == null)
            return;

        playerCoins.ColetarEstrela();

        Destroy(gameObject);
    }
}