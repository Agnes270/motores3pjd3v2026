using TMPro;
using UnityEngine;

public class CoinUI : MonoBehaviour
{
    public TMP_Text coinText;

    private void Start()
    {
        coinText.text = "Moedas: 0";

        PlayerObserverManager.OnCoinCountChanged += UpdateCoins;
    }

    private void OnDestroy()
    {
        PlayerObserverManager.OnCoinCountChanged -= UpdateCoins;
    }

    private void UpdateCoins(int amount)
    {
        coinText.text = "Moedas: " + amount;
    }
}