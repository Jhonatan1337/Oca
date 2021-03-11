using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using System;

public class MenuManager : MonoBehaviour, IDragHandler, IEndDragHandler, IBeginDragHandler
{
    public static GameObject itemDragging;

    Vector3 startPosition;
    Transform startParent;
    Transform dragParent;

    // Start is called before the first frame update
    void Start()
    {
        dragParent = GameObject.FindGameObjectWithTag("DragParent").transform;
    }

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

    //_____________________________________Drag________________________________________
    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("OnDrag");
        //Mueve el sprite a la posición del mouse
        transform.position = Input.mousePosition;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("OnEndDrag");
        itemDragging = null;
        if (transform.parent == dragParent)
        {
            transform.position = startPosition;
            transform.SetParent(startParent);
        }
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("OnBeginDrag");
        itemDragging = gameObject;
        startPosition = transform.position;
        startParent = transform.parent;
        transform.SetParent(dragParent);
    }
    //_________________________________________________________________________________

}  
