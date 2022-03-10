using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class For : MonoBehaviour
{

    public int NumeroMultiplicador;

    void Start()
    {
        
        for (int i = 1; i <= 10; i++)
        {
            int Resultado = i * NumeroMultiplicador;
            Debug.Log(NumeroMultiplicador + " x " + i + " = " + Resultado);

        }

    }
}
