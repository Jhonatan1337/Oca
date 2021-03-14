using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropandDrag : MonoBehaviour
{
    public GameObject item;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (item != null && item.transform.parent != transform)
        {
            item = null;
        }
    }

    //___________________________________Drop__________________________________________
    public void OnDrop(PointerEventData eventData)
    {
        if (!item)
        {
            item = MenuManager.itemDragging;
            item.transform.SetParent(transform);
            item.transform.position = transform.position;

        }
    }
    //_________________________________________________________________________________
}
