using UnityEngine;

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

        if (Input.GetKey(KeyCode.D))

        {
            gameObject.transform.position += new Vector3(getVelocidade() * Time.deltaTime, 0, 0);
            spriteRenderer.flipX = false; // ADICIONADO: vira para a direita
            andando = true;
        }

        if (Input.GetKey(KeyCode.A))

        {
            gameObject.transform.position -= new Vector3(getVelocidade() * Time.deltaTime, 0, 0);
            spriteRenderer.flipX = true; // ADICIONADO: vira para a esquerda
            andando = true;

        }

        animator.SetBool("Andando", andando);
    }

}