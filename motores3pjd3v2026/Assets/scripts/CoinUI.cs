using TMPro;
using UnityEngine;

public class CoinUI : MonoBehaviour
{
    [SerializeField] private TMP_Text player1CoinText;
    [SerializeField] private TMP_Text player2CoinText;

    private void OnEnable()
    {
        PlayerObserverManager.OnCoinCountChanged += UpdateCoins;
    }

    private void OnDisable()
    {
        PlayerObserverManager.OnCoinCountChanged -= UpdateCoins;
    }

    private void Start()
    {
        player1CoinText.text = "Jogador 1: 0";
        player2CoinText.text = "Jogador 2: 0";
    }

    private void UpdateCoins(int playerIndex, int amount)
    {
        if (playerIndex == 1)
        {
            player1CoinText.text = "Jogador 1: " + amount;
        }
        else if (playerIndex == 2)
        {
            player2CoinText.text = "Jogador 2: " + amount;
        }
    }
}