using System.Collections;
using UnityEngine;

public class AnimatorFuegoController : MonoBehaviour
{
    
    private Animator animator;
    void Start()
    {
        
        animator = GetComponent<Animator>();
        StartCoroutine(prenderFuego());
    }

    
    void Update()
    {
        
    }


    private IEnumerator prenderFuego()
    {
        while (true)
        {
            yield return new WaitForSeconds(3f);
            animator.SetBool("isOn",true);
            yield return new WaitForSeconds(3f);
            animator.SetBool("isOn", false);
        }
    }
}
