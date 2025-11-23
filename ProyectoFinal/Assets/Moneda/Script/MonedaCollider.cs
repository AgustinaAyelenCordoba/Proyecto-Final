using UnityEngine;

public class MonedaCollider : MonoBehaviour
{
   [SerializeField] private AudioClip AudioClip;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        { 
        
            Destroy(gameObject);
            AudioManager.Instance.PlaySoundEffect(AudioClip,0.5f);
        
        }
    }

}
