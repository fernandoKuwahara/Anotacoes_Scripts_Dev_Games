using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiate_Destroy : MonoBehaviour
{
    //Cria Uma Variável Publica Do Tipo GameObject, Que Irá Conter O Prefab.
    public GameObject Prefab;

    //Cria Uma Variável Publica Do Tipo GameObject, Que Irá Conter O Um Objeto Para Controlar A Posição Do Prefab.
    public GameObject Pai;

    //Método Update, Padrão Da Unity, Que Executa Qualquer Código, A Cada Frame Do Jogo.
    void Update()
    {
        //Chama E Executa O Método CriarCubo.
        CriarCubo();
    }

    //Método CriarCubo, É Usado Para Clonar Um Prefab.
    void CriarCubo()
    {
        //If De Controle Para Saber Quando A Tecla <A> É Pressionada.
        if (Input.GetKeyDown(KeyCode.A))
        {
            //Método Instantiate Que Cria Um Novo Objeto(Clone), Do Prefab Referênciado.
            Instantiate(Prefab, new Vector3(3,0,0), Quaternion.identity);

            //Prefab É O Objeto Que Irá Ser Clonado Na Cena.
            //O new Vector3, Foi Utilizado Como Parâmetro Para Determinar A Posição De Spawn Do Prefab.
            //O Quartenion, Foi Utilizado Como Parâmetro Para Retornar A Propriedade Rotation Do Transform, Do GameObject Atrelado Há Esse Script(Instantiate_Destroy).
        }
    }
}
