using UnityEngine;
using UnityEngine.UI;

public class PainelDeVida: MonoBehaviour
{
    public Personagem personagem;
    
    public Slider sliderVidas;
    public Slider sliderEnergia;

    void Start()
    {
        sliderVidas.minValue = 0;
        sliderVidas.maxValue = personagem.getvidas();

        sliderEnergia.minValue = 0;
        sliderEnergia.maxValue = personagem.getEnergia();
        
    }

    void Update()
    {
        sliderVidas.value = personagem.getvidas();
        sliderEnergia.value = personagem.getEnergia();
    }
       
}