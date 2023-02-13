using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using System;

public class MenuManager : MonoBehaviour
{
    public static GameObject itemDragging;

    

    // Update is called once per frame
    void Update()
    {
        
    }


    //________________________________Cambio de Escena_________________________________
    public void EscenaMenu()
    {
        SceneManager.LoadScene("Jugadores");
    }

    public void CargarNivel(string nombreNivel)
    {
        SceneManager.LoadScene(nombreNivel);
    }


    //_________________________________________________________________________________

}  
