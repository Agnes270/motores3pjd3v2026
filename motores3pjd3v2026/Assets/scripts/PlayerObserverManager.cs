using System;

public static class PlayerObserverManager
{
   
    public static Action<int, int> OnCoinCountChanged;

    public static void NotifyCoinCountChanged(int playerIndex, int amount)
    {
        OnCoinCountChanged?.Invoke(playerIndex, amount);
    }

   
    public static Action<int, int> OnStarCountChanged;

    public static void NotifyStarCountChanged(int playerIndex, int amount)
    {
        OnStarCountChanged?.Invoke(playerIndex, amount);
    }
}