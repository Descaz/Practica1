using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem.Controls;
using UnityEngine.Rendering.Universal;

[RequireComponent(typeof(CharacterController))]
public class PlayerMovement : MonoBehaviour
{
    private CharacterController controller; //Controller del personaje
    private AudioSource audioSource;
    [SerializeField] private AudioClip pasos; //En caso de querer poner más de un sonido

    [Range(1, 20)] //Slider para que eljugador pueda elegir la velocidad de movimiento del personaje
    public float velocidad;

    [Range(5.0f, 150.0f)] //Slider para que eljugador pueda elegir la velocidad de giro del personaje
    public float velocidadDeGiro;

    private Vector3 movimiento = Vector3.zero; //Creamos un vector para el movimiento y se incializa a 0

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        controller = this.GetComponent<CharacterController>();
        velocidad = 10; //Velocidad por defecto
        velocidadDeGiro = 80.0f; //Velocidad de giro por defecto
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = pasos;
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        //Rotación del personaje
        Vector3 rotation = new Vector3(0, horizontal * velocidadDeGiro * Time.deltaTime, 0);
        this.transform.Rotate(rotation);

        //Movimiento del personaje
        movimiento = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        movimiento = transform.TransformDirection(movimiento); 
        
        /*Se comprueba si se está pulsando las teclas. Está programado para tener "tank controls"
          y que se reproduzca un sonido al andar*/
        if (vertical == 1 && horizontal == 0)
        {
            controller.Move(movimiento * velocidad * Time.deltaTime);
            if (!audioSource.isPlaying)
            {
                audioSource.Play();
            }
        }
        if (vertical == -1 && horizontal == 0)
        {
            controller.Move(movimiento * velocidad * Time.deltaTime);
            if (!audioSource.isPlaying)
            {
                audioSource.Play();
            }
            
        }       
    }
}
