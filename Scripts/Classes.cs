using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Classes : MonoBehaviour
{
    //Classe Do Inimigo1
    [System.Serializable]
    public class Inimigo1
    {
        //Atributos Do Inimigo1
        public string NomeInimigo;
        public int DanoInimigo;
        public int VidaInimigo;

        //Construtor Do Inimigo1
        public Inimigo1(string nome, int dano, int vida)
        {
            NomeInimigo = nome;
            DanoInimigo = dano;
            VidaInimigo = vida;
        }
    }

    //Classe Do Inimigo2
    [System.Serializable]
    public class Inimigo2
    {
        //Atributos Do Inimigo2
        public string NomeInimigo;
        public int DanoInimigo;
        public int VidaInimigo;

        //Construtor Do Inimigo2
        public Inimigo2(string nome, int dano, int vida)
        {
            NomeInimigo = nome;
            DanoInimigo = dano;
            VidaInimigo = vida;
        }

        public void Inimigo()
        {
            Debug.Log("Legal!");
        }
    }

    //Objeto Do Inimigo1
    public Inimigo1 Enemy1;

    //Objeto Do Inimigo2
    public Inimigo2 Enemy2;

    void Start() {
        //Debug Dos Nomes Dos Inimigos
        Debug.Log(Enemy1.NomeInimigo);
        Debug.Log(Enemy2.NomeInimigo);
    }
}
