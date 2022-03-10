using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Statics : MonoBehaviour
{
    //Declara A Variável Que Possui A Vida DO Jogador, Tipo Inteiro.
    public int VidaJogador;

    //Declara A Variável Controle Com A Propriedade Static, Tipo Statics(Está Classe).
    public static Statics Controle;

    //Void Awake, Tem A Mesma Função Do Void Start, Primeiro A Executar E Apenas Uma Vez, Porém, É Executado Antes Do Void Start, Tendo Prioridade.
    void Awake()
    {
        //Atribui Está Classe, Usando O This, Há Variável Controle. 
        Controle = this;
        
    }

    //Método Que Aumenta A Vida Do Jogador.
    public void AumentarVida()
    {
        //If De Controle Para Aumentar A Vida Do Jogador.
        if (VidaJogador <= 10)
        {
            //Atribui A Vida Do Jogador Como 10.
            VidaJogador = 10;
        }
        //Debuga A Vida Do Jogador Para Confirmar.
        Debug.Log("Você Recuperou Vida: " + VidaJogador);
    }
}
