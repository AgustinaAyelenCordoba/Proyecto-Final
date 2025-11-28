using UnityEngine;

public class MonedaCollider : MonoBehaviour
{
   [SerializeField] private AudioClip AudioClip;
    private int puntaje=1;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        { 
        
            Destroy(gameObject);
            AudioManager.Instance.PlaySoundEffect(AudioClip);
            GameManager.Instance.mostrarPuntaje(puntaje);
        }
    }

}
