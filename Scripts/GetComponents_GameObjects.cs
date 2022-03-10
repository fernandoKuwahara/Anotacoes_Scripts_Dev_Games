using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetComponents_GameObjects : MonoBehaviour
{

    //Declara A Variável Do Tipo GameObject.
    public GameObject objeto;
    //Delara A Variável Do Tipo Light.
    Light luz;

    void Start()
    {
        //Testes Para Mudar A Cor Do Componente Luz Na Cena.
        // luz = objeto.GetComponent<Light>();
        // Debug.Log(luz.color);
        // luz.color = Color.blue;
        // Debug.Log(luz.color);

        if (objeto.activeSelf)
        {
            //Maneira 1 De Desativar A Luz, Desativando O Próprio GameObject.
            objeto.SetActive(false);
        }
        else
        {
            //Maneira 1 De Ativar A Luz, Ativando O Próprio GameObject.
            objeto.SetActive(true);
        }

        //Testes De Controle Para Setar A Propriedade Enabled Do Componente Light.
        if (objeto.GetComponent<Light>().enabled)
        {
            //Maneira 2 De Desativar A Luz, Desativando O Componente Luz.
            // objeto.GetComponent<Light>().enabled = false;
            // Debug.Log(objeto.GetComponent<Light>().enabled);
        }
        else
        {
            //Maneira 2 De Ativar A Luz, Ativando O Componente Luz.
            // objeto.GetComponent<Light>().enabled = true;
            // Debug.Log(objeto.GetComponent<Light>().enabled);
        }
    }
}
