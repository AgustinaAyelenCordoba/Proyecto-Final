using UnityEngine;
using UnityEngine.SceneManagement;

public class nextLevel : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        int index = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(index+1);
    }
}
