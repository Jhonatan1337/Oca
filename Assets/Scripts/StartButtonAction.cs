using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartButtonAction : MonoBehaviour
{

    public StateManager stateManager;
    public GameObject startButton;

    // Start is called before the first frame update
    void Start()
    {
        stateManager = GameObject.FindGameObjectWithTag("GameState").GetComponent<StateManager>();
        if (stateManager == null)
        {
            Debug.LogError("No se encontró el objeto StateManager en la escena actual.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        switch(stateManager.jugadores)
        {
            case 1:
                startButton.SetActive(player1Ready());
                break;
            case 2:
                startButton.SetActive(player2Ready());
                break;
            case 3:
                startButton.SetActive(player3Ready());
                break;
            case 4:
                startButton.SetActive(player4Ready());
                break;
            default:
                break;
        }
    }

    private bool player1Ready()
    {
        return stateManager.skinJugador1 != 0;
    }

    private bool player2Ready()
    {
        return stateManager.skinJugador2 != 0 && player1Ready();
    }

    private bool player3Ready()
    {
        return stateManager.skinJugador3 != 0 && player2Ready();
    }

    private bool player4Ready()
    {
        return stateManager.skinJugador4 != 0 && player3Ready();
    }
}
