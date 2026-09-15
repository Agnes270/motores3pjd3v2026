using System;

public static class PlayerObserverManager
{
    public static Action<int, int> OnCoinCountChanged;

    public static void NotifyCoinCountChanged(int playerIndex, int amount)
    {
        OnCoinCountChanged?.Invoke(playerIndex, amount);
    }
}