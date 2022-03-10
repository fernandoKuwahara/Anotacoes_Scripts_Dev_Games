using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyCube : MonoBehaviour
{
    //Método Start, Padrão Da Unity, Que Executa Qualquer Código, No Inicio Do Jogo, Apenas Uma Vez.
    void Start()
    {
        //Chama E Executa O Método DestruirCubo.
        DestruirCubo();
    }

    //Método DestruirCubo, É Usado Para Destruir O Objeto Atrelado Há Este Script(DestroyCube).
    void DestruirCubo()
    {
        //Método Destroy Que Destroy O Objeto(Clone), Do Prefab Referênciado.
        Destroy(gameObject,2f);

        //O gameObject Com G Minúsculo, Simboliza Que Será Utilizado O Próprio GameObject Atrelado Há Este Script(DestroyCube).
        //O 2f Foi Passado Como Parâmetro Para SImbolizar O Intervalo De Tempo Até Que O GameObject Seja Destruído.
    }
}
