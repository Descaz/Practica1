using UnityEngine;

public class Cam : MonoBehaviour
{
    //Creamos las camaras públicas para poder referenciarlas en el inspector
    public Camera cam1; //Creamos las camaras públicas para poder referenciarlas en el inspector
    public Camera cam2;
    
    private void Start()
    {
        //Activamos la cámara en primera persona por defecto.
        cam1.gameObject.SetActive(true);
        cam2.gameObject.SetActive(false);       
    }

    private void ClickCamara()
    {
        //Si no está activa la otra cámara, la activamos.
        cam1.gameObject.SetActive (!cam1.gameObject.activeSelf);
        cam2.gameObject.SetActive(!cam2.gameObject.activeSelf);      
    }
}
