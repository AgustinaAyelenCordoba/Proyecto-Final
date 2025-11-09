using UnityEngine;

public class FondoMovimiento : MonoBehaviour
{
    [SerializeField] private Vector2 velocidadMovimiento;
    private Vector2 offset; private Material material;
    //private Rigidbody2D jugadorRD;
    private void Awake()
    {
        material = GetComponent<SpriteRenderer>().material;
        //jugadorRD = GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        offset = velocidadMovimiento * Time.deltaTime;
        material.mainTextureOffset += offset;
    }
    //(jugadorRD.linearVelocity.x / 10f)
}