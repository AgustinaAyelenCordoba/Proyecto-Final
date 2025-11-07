using UnityEngine;

public class CollicionPuas : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("Entro al jugador");
        }
    }

}
