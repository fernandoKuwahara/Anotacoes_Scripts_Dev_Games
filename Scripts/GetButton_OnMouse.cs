using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetButton_OnMouse : MonoBehaviour
{

    public GameObject objeto;
    Light luz;

    void Start() {

        //Testes De Controle Para Setar A Propriedade Enabled Do Componente Light.
        if (objeto.GetComponent<Light>().enabled.Equals(false))
        {
            //Ativa A Luz, Ativando O Componente Luz.
            objeto.GetComponent<Light>().enabled = true;
            Debug.Log(objeto.GetComponent<Light>().enabled);
        }

        luz = objeto.GetComponent<Light>();    
    }

    void Update()
    {
        //Teste Do Input GetKey
        // if (Input.GetKey(KeyCode.L))
        // {
        //     luz.enabled = true;
        //     Debug.Log("LIGA!");
        // }
        // if (Input.GetKey(KeyCode.D))
        // {
        //     luz.enabled = false;
        //     Debug.Log("DESLIGA!");
        // }

        //Teste Do Input GetKeyDown
        if (Input.GetKeyDown(KeyCode.L))
        {
            luz.enabled = true;
            Debug.Log("LIGA!");
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            luz.enabled = false;
            Debug.Log("DESLIGA!");
        }

        //Teste Do Input GetKeyUp
        // if (Input.GetKeyUp(KeyCode.L))
        // {
        //     luz.enabled = true;
        //     Debug.Log("LIGA!");
        // }
        // if (Input.GetKeyUp(KeyCode.D))
        // {
        //     luz.enabled = false;
        //     Debug.Log("DESLIGA!");
        // }

    }

    //Teste Da Ação OnMouseDown.
    private void OnMouseDown() 
    {
        //If Para Controle Da Cor Da Luz
        if (luz.color == Color.blue)
        {
            luz.color = Color.white;
        }
        else
        {
            luz.color = Color.blue;
        }
    }

    //Teste Da Ação OnMouseUp.
    // private void OnMouseUp() 
    // {
    //     //If Para Controle Da Cor Da Luz
    //     if (luz.color == Color.blue)
    //     {
    //         luz.color = Color.white;
    //     }
    //     else
    //     {
    //         luz.color = Color.blue;
    //     }
    // }

    //Teste Da Ação OnMouseDrag.
    // private void OnMouseDrag() 
    // {
    //     //If Para Controle Da Cor Da Luz
    //     if (luz.color == Color.blue)
    //     {
    //         luz.color = Color.white;
    //     }
    //     else
    //     {
    //         luz.color = Color.blue;
    //     }
    // }

    //Teste Da Ação OnMouseOver.
    // private void OnMouseOver() 
    // {
    //     //If Para Controle Da Cor Da Luz
    //     if (luz.color == Color.blue)
    //     {
    //         luz.color = Color.white;
    //     }
    //     else
    //     {
    //         luz.color = Color.blue;
    //     }
    // }

    //Teste Da Ação OnMouseEnter.
    // private void OnMouseEnter() 
    // {
    //     //If Para Controle Da Cor Da Luz
    //     if (luz.color == Color.blue)
    //     {
    //         luz.color = Color.white;
    //     }
    //     else
    //     {
    //         luz.color = Color.blue;
    //     }
    // }

    //Teste Da Ação OnMouseUpAsButton.
    // private void OnMouseUpAsButton() 
    // {
    //     //If Para Controle Da Cor Da Luz
    //     if (luz.color == Color.blue)
    //     {
    //         luz.color = Color.white;
    //     }
    //     else
    //     {
    //         luz.color = Color.blue;
    //     }
    // }

    //Teste Da Ação OnMouseExit.
    // private void OnMouseExit() 
    // {
    //     //If Para Controle Da Cor Da Luz
    //     if (luz.color == Color.blue)
    //     {
    //         luz.color = Color.white;
    //     }
    //     else
    //     {
    //         luz.color = Color.blue;
    //     }
    // }
}
