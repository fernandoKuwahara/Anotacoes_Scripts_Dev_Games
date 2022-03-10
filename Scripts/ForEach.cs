using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForEach : MonoBehaviour
{

    string[] Inimigos = new string[10];
    public int NumeroMultiplicador;

    void Start()
    {
        
        for (int i = 0; i <= 9; i++)
        {
            Inimigos[i] = ("O Número De Inimigos É Igual A: " + i * NumeroMultiplicador);
        }

        foreach (string i in Inimigos)
        {
            Debug.Log(i);
        }

    }
}
