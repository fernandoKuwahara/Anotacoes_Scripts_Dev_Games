using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class While_DoWhile : MonoBehaviour
{

    // int ItensDaCena = 5;
    int Dinheiro = 500;

    void Start()
    {
        // while (ItensDaCena > 0)
        // {
        //     Debug.Log("Item Coletado");
        //     ItensDaCena--;
        // }

        do
        {
            Debug.Log("O Seu Dinheiro É: " + Dinheiro);
            Dinheiro += 50;
        } while (Dinheiro <= 1000);
    }
}
