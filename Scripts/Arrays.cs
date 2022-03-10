using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrays : MonoBehaviour
{

    //Declaração De Array Do Tipo GameObject.
    public GameObject[] ObjetosDaCena;

    void Start()
    {

        //Preenchimento Do Array, Com Elementos Com A Tag Player.
        ObjetosDaCena = GameObject.FindGameObjectsWithTag("Player");

        //For Para Percorrer O Array E Debugar O Resultado.
        // for (int i = 0; i < ObjetosDaCena.Length; i++)
        // {
        //     Debug.Log(ObjetosDaCena[i].name);
        // }

        //ForEach Para Percorrer O Array E Debugar O Resultado.
        foreach (GameObject ODC in ObjetosDaCena)
        {
            Debug.Log(ODC.name);
        }
    }
}
