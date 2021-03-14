using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSelection : MonoBehaviour
{

    public StateManager stateManager;

    // Start is called before the first frame update
    void Start()
    {
        stateManager = GameObject.FindGameObjectWithTag("GameState").GetComponent<StateManager>();
        if (stateManager == null)
        {
            Debug.LogError("No se encontró el objeto StateManager en la escena actual.");
        }

    }

    public void setPlayer(int playersNumber)
    {
        stateManager.jugadores = playersNumber;
    }
}
