using UnityEngine;

public class WinnerManager : MonoBehaviour
{
    private int player1Stars = 0;
    private int player2Stars = 0;

    private void OnEnable()
    {
        PlayerObserverManager.OnStarCountChanged += AtualizarEstrelas;
    }

    private void OnDisable()
    {
        PlayerObserverManager.OnStarCountChanged -= AtualizarEstrelas;
    }

    private void AtualizarEstrelas(int playerIndex, int amount)
    {
        if (playerIndex == 1)
        {
            player1Stars = amount;
        }
        else if (playerIndex == 2)
        {
            player2Stars = amount;
        }
    }

    public void VerificarVencedor()
    {
        Debug.Log(
            "FIM DA PARTIDA | Player 1: " +
            player1Stars +
            " estrelas | Player 2: " +
            player2Stars +
            " estrelas"
        );

        if (player1Stars > player2Stars)
        {
            PlayerObserverManager.NotifyWinnerDecided(1);
        }
        else if (player2Stars > player1Stars)
        {
            PlayerObserverManager.NotifyWinnerDecided(2);
        }
        else
        {
            PlayerObserverManager.NotifyWinnerDecided(0);
        }
    }
}