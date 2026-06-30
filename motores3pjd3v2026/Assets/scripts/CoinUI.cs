using TMPro;
using UnityEngine;

public class CoinUI : MonoBehaviour
{
    public TMP_Text coinText;

    private void Start()
    {
        coinText.text = "Moedas: 0";
        PlayerObserverManager.OnCoinCollected += UpdateCoins;
    }

    private void OnDestroy()
    {
        PlayerObserverManager.OnCoinCollected -= UpdateCoins;
    }

    void UpdateCoins(int amount)
    {
        coinText.text = "Moedas: " + amount;
    }
}