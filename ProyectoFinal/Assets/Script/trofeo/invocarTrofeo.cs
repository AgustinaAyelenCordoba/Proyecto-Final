using UnityEngine;

public class invocarTrofeo : MonoBehaviour
{
   [SerializeField] private GameObject GameObject;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Invoke("spawTrofeo", 2f); 
    }

    public void spawTrofeo() 
    {
        Instantiate(GameObject, transform.position, Quaternion.identity);
        

    }
}
