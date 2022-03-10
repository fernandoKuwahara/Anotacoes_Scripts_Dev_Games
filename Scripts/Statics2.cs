using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Statics2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Debuga A Vida Do Jogador Primeiro.
        Debug.Log("Sua Vida É: " + Statics.Controle.VidaJogador);
        //Chama E Executa O Método AumentarVida Da Classe Statics.
        Statics.Controle.AumentarVida();
    }
}
