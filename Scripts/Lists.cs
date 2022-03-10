using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lists : MonoBehaviour
{
    //Classe Do Inimigo
    [System.Serializable]
    public class Inimigo 
    {
        //Atributos Do Inimigo
        public string NomeInimigo;
        public int VidaInimigo;
        public int DanoInimigo;

        //Construtor Da Classe Inimigo
        public Inimigo(string n, int v, int d)
        {
            //Atribuição Aos valores Atributos Do Inimigo
            NomeInimigo = n;
            VidaInimigo = v;
            DanoInimigo = d;
        }
    }

    //Lista Do Tipo Inimigo
    public List<Inimigo> Inimigos = new List<Inimigo>();

    void Start()
    {
        //Adiciona Um Novo Inimigo Na Lista Inimigos, Com Atributos Do Tipo Da Lista(Classe Inimigo)
        Inimigos.Add(new Inimigo("Fernando", 100, 10));
        Inimigos.Add(new Inimigo("Francisco", 10, 50));
    }
}
