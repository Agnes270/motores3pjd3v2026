using UnityEngine;

public class Estrela : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player"))
            return;

        Debug.Log("ESTRELA TOCOU NO PLAYER: " + other.name);

        PlayerCoins playerCoins = other.GetComponentInParent<PlayerCoins>();

        if (playerCoins == null)
        {
            Debug.LogError("PLAYERCOINS NÃO ENCONTRADO!");
            return;
        }

        Debug.Log("ESTRELA COLETADA PELO: " + playerCoins.name);

        playerCoins.ColetarEstrela();

        Destroy(gameObject);
    }
}