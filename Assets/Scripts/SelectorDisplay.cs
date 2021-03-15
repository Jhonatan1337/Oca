using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectorDisplay : MonoBehaviour
{
    
    public int playerNumberRepresent;
    public StateManager stateManager;

    // Start is called before the first frame update
    void Start()
    {
        stateManager = GameObject.FindGameObjectWithTag("GameState").GetComponent<StateManager>();
        if (stateManager == null)
        {
            Debug.LogError("No se encontró el objeto StateManager en la escena actual.");
        }

        if (stateManager.jugadores < 0 || stateManager.jugadores > playerNumberRepresent)
        {
            Destroy(this.gameObject);
        }
    }

}
