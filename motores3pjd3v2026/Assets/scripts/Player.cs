using UnityEngine;
using UnityEngine.InputSystem;

public class Player : Personagem
{
    private SpriteRenderer spriteRenderer;
    private Animator animator;

    private bool andando = false;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        andando = false;

        if (Keyboard.current.dKey.isPressed)
        {
            transform.position += new Vector3(getVelocidade() * Time.deltaTime, 0, 0);
            spriteRenderer.flipX = false;
            andando = true;
        }

        if (Keyboard.current.aKey.isPressed)
        {
            transform.position -= new Vector3(getVelocidade() * Time.deltaTime, 0, 0);
            spriteRenderer.flipX = true;
            andando = true;
        }

        animator.SetBool("Andando", andando);
    }
}