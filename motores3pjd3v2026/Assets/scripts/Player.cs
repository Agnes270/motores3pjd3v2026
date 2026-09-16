using UnityEngine;
using UnityEngine.InputSystem;

public class Player : Personagem
{
    private SpriteRenderer spriteRenderer;

    private Vector2 movimento;

    // Aumenta 2 pontos a cada moeda
    private float velocidadeExtra = 0f;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();

        Debug.Log("Jogador iniciado. Velocidade base: " + getVelocidade());
    }

    public void OnMove(InputValue value)
    {
        movimento = value.Get<Vector2>();
    }

    public void AumentarVelocidade()
    {
        velocidadeExtra += 2f;

        Debug.Log(
            "VELOCIDADE AUMENTOU! Base: "
            + getVelocidade()
            + " | Extra: "
            + velocidadeExtra
            + " | FINAL: "
            + (getVelocidade() + velocidadeExtra)
        );
    }

    void Update()
    {
        Vector3 direcao = new Vector3(
            movimento.x,
            0f,
            movimento.y
        );

        float velocidadeFinal = getVelocidade() + velocidadeExtra;

        transform.position += direcao * velocidadeFinal * Time.deltaTime;

        if (spriteRenderer != null)
        {
            if (movimento.x > 0)
            {
                spriteRenderer.flipX = false;
            }
            else if (movimento.x < 0)
            {
                spriteRenderer.flipX = true;
            }
        }
    }
}