using System.Collections;
using UnityEngine;

public class Cofre : MonoBehaviour
{
    private Animator Animator;


    public void Start()
    {
      Animator = GetComponent<Animator>();

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        StartCoroutine(abrirCofre());
       
    }

    IEnumerator abrirCofre() 
    {

        
        yield return new WaitForSeconds(2);
        Animator.SetBool("isOpen", true);
        yield return new WaitForSeconds(3);
        Destroy(gameObject);

    }
}
