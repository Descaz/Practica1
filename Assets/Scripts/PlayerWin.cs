using UnityEngine;


public class PlayerWin : MonoBehaviour
{
    private AudioSource audioSource;

    //Guardamos más de un sonido
    [SerializeField] private AudioClip win; 
    [SerializeField] private AudioClip musica;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        this.GetComponent<Renderer>().enabled = false;
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = musica; 
        audioSource.Play(); //Reproduce música de fondo.
    }

    //Si llega a la meta, se reproduce un sonido de victoria
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("PLAYER WINS");
        audioSource.clip = win;
        audioSource.volume = 1.0f;
        audioSource.Play();
    }
}

