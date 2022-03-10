using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variáveis : MonoBehaviour
{
    //Aula Variáveis

    //Como Declarar Uma Variável
    public int ValorInteiro;
    private int ValorInt;
    public bool ValorBooleano;

    //int Valor é Igual private int Valor
    int Valor;

    //Como Não Declarar Uma Variável
    public float numerosDecimais;
    public float valorinteiro;

    //Declarar Variáveis da Untiy
    public GameObject Gameobject;
    public Transform TransformUnity;

    void Start() 
    {
        //Atribui O Próprio GameObject Deste Script, Á Variável Do Tipo GameObject
        Gameobject = gameObject;
    }
}
