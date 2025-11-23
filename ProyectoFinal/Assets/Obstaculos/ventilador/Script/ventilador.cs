using UnityEngine;

public class ventilador : MonoBehaviour
{
    [SerializeField] private float fuerzaViento;
    [SerializeField] private Vector3 direccionViento;
  
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        Rigidbody2D objeto = collision.gameObject.GetComponent<Rigidbody2D>();
        objeto.AddForce(direccionViento* fuerzaViento * Time.deltaTime, ForceMode2D.Force);
        
    }
    





}
