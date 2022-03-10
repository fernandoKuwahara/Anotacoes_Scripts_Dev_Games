using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class If : MonoBehaviour
{
    //Aula Estruturas Condicionais IF - ELSE - ELSE IF
    public int n1;
    public int n2;
    public bool Valor;
    void Start() 
    {
        Debug.Log(Valor);
        Debug.Log(n1 + " " + n2);

        if(n1 > 0)
        {
            Debug.Log("O Número Informado É Positivo!");
        }
        else if(n1 < 0)
        {
            Debug.Log("O Número Informado É Negativo!");
        }
        else
        {
            Debug.Log("O Número É Zero!");
        }
    }
}
