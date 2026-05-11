using UnityEngine;

public class Personagem : MonoBehaviour
{

    [SerializeField] private int vidas;
    [SerializeField] private int energia;
    [SerializeField] private float velocidade;

    public void setvidas(int vidas)
    {
        this.vidas = vidas;
    }

    public int getvidas()
    {
        return this.vidas;
    }

    public void setEnergia(int energia)
    {
        this.energia = energia;
    }

    public int getEnergia()
    {
        return this.energia;
    }

    public void setvelocidade(float velocidade)
    {
        this.velocidade = velocidade;
    }

    public float getVelocidade()
    {
        return this.velocidade;
    }

}