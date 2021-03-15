using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropObject : MonoBehaviour, IDropHandler
{

    public int player;
    private StateManager stateManager;

    void Start()
    {
        stateManager = GameObject.FindGameObjectWithTag("GameState").GetComponent<StateManager>();
        if (stateManager == null)
        {
            Debug.LogError("No se encontró el objeto StateManager en la escena actual.");
        }
        if (player == 0)
        {
            Debug.LogError("No se ha definido el jugador al que pertenece el selector.");
        }
    }

    public void OnDrop(PointerEventData eventData)
    {
        GameObject obj = eventData.pointerDrag;
        if (eventData.pointerDrag != null)
        {
            DragObjectSelector dos = obj.GetComponent<DragObjectSelector>();
            dos.isDropped = true;
            obj.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
            switch (player)
            {
                case 1:
                    if (stateManager.skinJugador1 != 0)
                    {
                        dos.returnOldPosition();
                    } else
                    {
                        dos.assignedPlayer = 1;
                        stateManager.skinJugador1 = dos.skinNumber;
                    }                    
                    break;
                case 2:
                    if (stateManager.skinJugador2 != 0)
                    {
                        dos.returnOldPosition();
                    }
                    else
                    {
                        dos.assignedPlayer = 2;
                        stateManager.skinJugador2 = dos.skinNumber;
                    }
                    break;
                case 3:
                    if (stateManager.skinJugador3 != 0)
                    {
                        dos.returnOldPosition();
                    }
                    else
                    {
                        dos.assignedPlayer = 3;
                        stateManager.skinJugador3 = dos.skinNumber;
                    }
                    break;
                case 4:
                    if (stateManager.skinJugador4 != 0)
                    {
                        dos.returnOldPosition();
                    }
                    else
                    {
                        dos.assignedPlayer = 4;
                        stateManager.skinJugador4 = dos.skinNumber;
                    }
                    break;
                default:
                    Debug.LogError("No se ha definido el jugador al que pertenece el selector.");
                    break;
            }
        }
    }
}
