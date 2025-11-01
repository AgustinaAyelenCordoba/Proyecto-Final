using UnityEngine;

public class AnimationPlayerController : MonoBehaviour
{
    private Animator animator;


    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        MoveAnimetor();
    }


    void MoveAnimetor()
    {
        float moveX;
        moveX = Input.GetAxisRaw("Horizontal");
        if (moveX > 0 )
        {
            animator.SetBool("isMove", true);
            transform.localScale = new Vector3(1f, 1f, 1f);
        } else if (moveX <0 )
        {
            transform.localScale=new Vector3(-1f,1f,1f);
            animator.SetBool("isMove", true);
        }
        else
        {
            animator.SetBool("isMove", false);
        }
    }
}
