using UnityEngine;
using UnityEngine.InputSystem;

public class Player : Personagem
{
    private SpriteRenderer spriteRenderer;
    private Animator animator;

    private Vector2 movimento;
    private bool andando = false;

    private float velocidadeExtra = 0f;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
    }

    public void OnMove(InputValue value)
    {
        movimento = value.Get<Vector2>();
    }

    public void AumentarVelocidade()
    {
        velocidadeExtra += 1f;
    }

    void Update()
    {
        Vector3 direcao = new Vector3(
            movimento.x,
            0,
            movimento.y
        );

        transform.position += direcao *
                              (getVelocidade() + velocidadeExtra) *
                              Time.deltaTime;

        andando = movimento != Vector2.zero;

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

        if (animator != null)
        {
            animator.SetBool("Andando", andando);
        }
    }
}