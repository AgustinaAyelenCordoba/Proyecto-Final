using UnityEngine;

public class ColliserPlataforma : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
           collision.gameObject.transform.SetParent(collision.transform);
            
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            transform.SetParent(null);
        }
    }
}
