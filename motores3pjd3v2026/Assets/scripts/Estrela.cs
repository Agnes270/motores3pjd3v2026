using UnityEngine;

public class Estrela : MonoBehaviour
{
    public static int estrelasColetadas = 0;

    private bool foiColetada = false;

    private void OnTriggerEnter(Collider other)
    {
        if (foiColetada)
            return;

        if (!other.CompareTag("Player"))
            return;

        PlayerCoins playerCoins = other.GetComponent<PlayerCoins>();

        if (playerCoins == null)
        {
            Debug.LogError("PLAYERCOINS NÃO ENCONTRADO!");
            return;
        }

        foiColetada = true;

        Debug.Log("ESTRELA COLETADA PELO: " + playerCoins.name);

        playerCoins.ColetarEstrela();

        estrelasColetadas++;

        Debug.Log(
            "ESTRELAS COLETADAS NO TOTAL: " +
            estrelasColetadas + "/6"
        );

        Destroy(gameObject);

        if (estrelasColetadas >= 6)
        {
            WinnerManager winnerManager =
                FindFirstObjectByType<WinnerManager>();

            if (winnerManager != null)
            {
                winnerManager.VerificarVencedor();
            }
            else
            {
                Debug.LogError("WinnerManager não encontrado!");
            }
        }
    }
}