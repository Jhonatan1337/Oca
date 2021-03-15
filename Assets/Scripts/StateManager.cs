using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateManager : MonoBehaviour
{

    [Header("Propiedes del juego")]
    public int jugadores;
    public int skinJugador1;
    public int skinJugador2;
    public int skinJugador3;
    public int skinJugador4;
    public int tablero;
    public List<Sprite> skinSprites;

    // Se llama cuando el objeto es cargado en memoria.
    void Awake()
    {
        //Evita que se genere nuevamente el objeto si este ya fue cargado previamente en otra escena.
        GameObject[] objs = GameObject.FindGameObjectsWithTag("GameState");
        if(objs.Length > 1)
        {
            Destroy(this.gameObject);
        }

        /* Evita que el objeto se elimine de memoria al cargar otra escena.
         * sin embargo, el objeto debe existir en la escena destino para usar
         * sus propiedades.
         */
        DontDestroyOnLoad(this.gameObject);
    }


}
