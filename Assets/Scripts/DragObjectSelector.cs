using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;

public class DragObjectSelector : MonoBehaviour, IBeginDragHandler, IEndDragHandler,
    IDragHandler
{

    [SerializeField] private Canvas canvas;

    [Header("Propiedades de ficha")]
    public bool isDropped;
    public int skinNumber;
    public int oldPlayer;
    public int assignedPlayer;
    public Vector2 defaultPosition;
    public StateManager stateManager;

    private RectTransform rectTransform;
    private CanvasGroup canvasGroup;    

    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();
        stateManager = GameObject.FindGameObjectWithTag("GameState").GetComponent<StateManager>();
        if (stateManager == null)
        {
            Debug.LogError("No se encontró el objeto StateManager en la escena actual.");
        }
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        isDropped = false;
        oldPlayer = assignedPlayer;
        canvasGroup.blocksRaycasts = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        canvasGroup.alpha = 0.75f;
        rectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        canvasGroup.alpha = 1f;
        canvasGroup.blocksRaycasts = true;
        if (oldPlayer != assignedPlayer)
        {
            switch (oldPlayer)
            {
                case 1:
                    stateManager.skinJugador1 = 0;
                    break;
                case 2:
                    stateManager.skinJugador2 = 0;
                    break;
                case 3:
                    stateManager.skinJugador3 = 0;
                    break;
                case 4:
                    stateManager.skinJugador4 = 0;
                    break;
                default:
                    break;
            }
        }
        if (!isDropped)
        {
            this.GetComponent<RectTransform>().anchoredPosition = defaultPosition;
            switch (assignedPlayer)
            {
                case 1:
                    stateManager.skinJugador1 = 0;
                    break;
                case 2:
                    stateManager.skinJugador2 = 0;
                    break;
                case 3:
                    stateManager.skinJugador3 = 0;
                    break;
                case 4:
                    stateManager.skinJugador4 = 0;
                    break;
                default:                    
                    break;
            }
            assignedPlayer = 0;
        }        
    }

    public void returnOldPosition()
    {
        isDropped = false;
        assignedPlayer = 0;
        oldPlayer = 0;
        this.GetComponent<RectTransform>().anchoredPosition = defaultPosition;
    }

}
