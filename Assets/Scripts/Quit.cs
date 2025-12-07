using UnityEngine;
using UnityEngine.UI;

public class Quit : MonoBehaviour
{
    //Este script nos permite cerrar el juego pulsando el botón en pantalla
    public void QuitGame()
    {
        Debug.Log("BOTON SALIR PULSADO");
        Application.Quit();
        Debug.Log("JUEGO TERMINADO");
    }

}
