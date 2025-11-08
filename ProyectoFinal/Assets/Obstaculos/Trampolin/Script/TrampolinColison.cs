using UnityEngine;

public class TrampolinColison : MonoBehaviour
{
    private Animator animation;
    [SerializeField] private float fuerzaSalto;
    private void Start()
    {
        animation = GetComponent<Animator>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Rigidbody2D objeto = collision.gameObject.GetComponent<Rigidbody2D>();
        objeto.AddForce(Vector2.up * fuerzaSalto * Time.deltaTime, ForceMode2D.Impulse);
        animation.SetBool("isOn", true);
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        animation.SetBool("isOn",false);
    }
}
