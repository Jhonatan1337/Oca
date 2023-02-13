using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SlotScript : MonoBehaviour, IDropHandler
{

    public int jugador;
    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("Item Colocado");
        if(eventData.pointerDrag != null)
        {
            if (eventData.pointerDrag.GetComponent<DragandDrop>().jugador == jugador )
            {
                _ = eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition;
            }
            else
            {
                eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = this.GetComponent<RectTransform>().anchoredPosition;
            }
        }
    }

}
