using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Metodos : MonoBehaviour
{

    //Declaração Da Variável Com A Vida Do Player.
    public int VidaPlayer;

    //Declaração Da Variável Com O Valor Do Dano.
    public int ValorDano;

    void Start()
    {
        //For Para Controlar O Dano No Player.
        for (int i = 0; i == 0;)
        {
            //Chama O Método DanoPlayer E Passa Como Parámetro O ValorDano.
            DanoPlayer(ValorDano);

            //Verifica Se A Vida Do Player É Menor Ou Igual A Zero.
            if (VidaPlayer <= 0)
            {
                Debug.Log("Player Morto!");
                i++;
            }
        }
    }

    //Método Que Faz O Player Perder Vida.
    void DanoPlayer(int Dano)
    {
        //Decrementa Da Vida Do Player Um Dano Específicado.
        VidaPlayer -= Dano;
    }
}
