using UnityEngine;

public class Player : Personagem
{
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * getVelocidade() * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.left * getVelocidade() * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.W))
        {
            transform.position += Vector3.forward * getVelocidade() * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.position += Vector3.back * getVelocidade() * Time.deltaTime;
        }
    }
}