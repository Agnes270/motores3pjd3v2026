using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class GameManager : MonoBehaviour
{
    // Singleton
    public static GameManager Instance;

    // Estados do jogo
    public enum GameState
    {
        Iniciando,
        MenuPrincipal,
        Gameplay
    }

    public GameState currentState;

    // Referência do PlayerInput
    public PlayerInput playerInput;

    private void Awake()
    {
        // Singleton
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        ChangeState(GameState.Iniciando);

        // Vai para Splash
        LoadScene("Splash");
    }

    // Trocar estado
    public void ChangeState(GameState newState)
    {
        currentState = newState;

        Debug.Log("Estado atual: " + currentState);
    }

    // Carregar cenas
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);

        // Define estados dependendo da cena
        switch (sceneName)
        {
            case "MenuPrincipal":
                ChangeState(GameState.MenuPrincipal);
                break;

            case "GetStarted_Scene":
                ChangeState(GameState.Gameplay);
                break;
        }
    }

    // Input do jogador
    public void AssignPlayerInput(PlayerInput input)
    {
        playerInput = input;

        Debug.Log("Input conectado ao jogador!");
    }

    // Sair do jogo
    public void QuitGame()
    {
        Debug.Log("Saindo do jogo...");
        Application.Quit();
    }
}