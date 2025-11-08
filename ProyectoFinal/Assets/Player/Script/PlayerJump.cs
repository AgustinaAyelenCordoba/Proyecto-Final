using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    private Rigidbody2D rigidbody2D;
    [SerializeField] private float _fuersaSalto;
    [SerializeField] private LayerMask _layerMask;
    private bool _isGround;
    private float _tiempoSalto = 0.5f;


    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Suelo();
        if (Input.GetKeyDown(KeyCode.Space) && (_isGround || _tiempoSalto > 0))
        {
            jump();
        }
        if (!_isGround)
        {
            _tiempoSalto -= Time.deltaTime;
        }
    }
    public void jump()
    {
        rigidbody2D.linearVelocity = new Vector2(rigidbody2D.linearVelocity.x, 0f);
        rigidbody2D.AddForce(Vector2.up * _fuersaSalto, ForceMode2D.Impulse);
    }
    public void Suelo()
    {
        Debug.DrawRay(transform.position, Vector3.down * 1.3f, Color.red);
        RaycastHit2D hit2D = Physics2D.Raycast(transform.position, Vector2.down, 1.3f, _layerMask);
        if (hit2D)
        {
            _isGround = true;
            _tiempoSalto = 0.2f;

        }
        else
        {
            _isGround = false;
        }
    }
}
