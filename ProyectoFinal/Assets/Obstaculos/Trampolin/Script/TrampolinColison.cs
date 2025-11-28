using UnityEngine;

public class TrampolinColison : MonoBehaviour
{
    private Animator trampolinAnimation;
    [SerializeField] private float fuerzaSalto;
    [SerializeField] private AudioClip AudioClip;
    private void Start()
    {
        trampolinAnimation = GetComponent<Animator>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Rigidbody2D objeto = collision.gameObject.GetComponent<Rigidbody2D>();
        objeto.AddForce(Vector2.up * fuerzaSalto * Time.deltaTime, ForceMode2D.Impulse);
        trampolinAnimation.SetBool("isOn", true);
        AudioManager.Instance.PlaySoundEffect(AudioClip);
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        trampolinAnimation.SetBool("isOn",false);
    }
}
