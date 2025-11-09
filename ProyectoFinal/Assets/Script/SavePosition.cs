using UnityEngine;

public class SavePosition : MonoBehaviour
{
    private SpawPlayer _spaw;
    private void Start()
    {
        _spaw = FindObjectOfType<SpawPlayer>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            _spaw.Index++;
            GetComponent<Collider2D>().enabled = false;
        }
    }
}
