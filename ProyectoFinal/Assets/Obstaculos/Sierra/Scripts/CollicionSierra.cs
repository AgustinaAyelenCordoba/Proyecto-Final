using UnityEngine;

public class CollicionSierra : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("Entro a la sierra");
        }
    }
}
