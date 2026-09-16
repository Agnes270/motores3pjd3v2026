using TMPro;
using UnityEngine;

public class CoinUI : MonoBehaviour
{
    [SerializeField] private TMP_Text player1CoinText;
    [SerializeField] private TMP_Text player2CoinText;

    private int player1Coins = 0;
    private int player2Coins = 0;

    private int player1Stars = 0;
    private int player2Stars = 0;

    private void OnEnable()
    {
        PlayerObserverManager.OnCoinCountChanged += UpdateCoins;
        PlayerObserverManager.OnStarCountChanged += UpdateStars;
    }

    private void OnDisable()
    {
        PlayerObserverManager.OnCoinCountChanged -= UpdateCoins;
        PlayerObserverManager.OnStarCountChanged -= UpdateStars;
    }

    private void Start()
    {
        AtualizarPlayer1();
        AtualizarPlayer2();
    }

    private void UpdateCoins(int playerIndex, int amount)
    {
        if (playerIndex == 1)
        {
            player1Coins = amount;
            AtualizarPlayer1();
        }
        else if (playerIndex == 2)
        {
            player2Coins = amount;
            AtualizarPlayer2();
        }
    }

    private void UpdateStars(int playerIndex, int amount)
    {
        if (playerIndex == 1)
        {
            player1Stars = amount;
            AtualizarPlayer1();
        }
        else if (playerIndex == 2)
        {
            player2Stars = amount;
            AtualizarPlayer2();
        }
    }

    private void AtualizarPlayer1()
    {
        if (player1CoinText != null)
        {
            player1CoinText.text =
                "Jogador 1\n" +
                "Moedas: " + player1Coins + "\n" +
                "Estrelas: " + player1Stars;
        }
    }

    private void AtualizarPlayer2()
    {
        if (player2CoinText != null)
        {
            player2CoinText.text =
                "Jogador 2\n" +
                "Moedas: " + player2Coins + "\n" +
                "Estrelas: " + player2Stars;
        }
    }
}