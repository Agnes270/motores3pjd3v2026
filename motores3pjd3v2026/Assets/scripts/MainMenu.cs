using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public void StartGame()
    {
        GameManager.Instance.LoadScene("Gameplay");
    }

    public void QuitGame()
    {
        Debug.Log("Saiu do jogo");

        Application.Quit();
    }
}