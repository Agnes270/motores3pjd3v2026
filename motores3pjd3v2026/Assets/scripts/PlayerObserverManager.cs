using System;

public static class PlayerObserverManager
{
    public static Action<int> OnCoinCollected;

    public static void NotifyCoinCollected(int amount)
    {
        OnCoinCollected?.Invoke(amount);
    }
}