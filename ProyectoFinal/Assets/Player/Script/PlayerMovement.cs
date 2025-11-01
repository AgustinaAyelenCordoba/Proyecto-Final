using UnityEngine;
using UnityEngine.Windows;

public class PlayerMovement : MonoBehaviour
{
    private Vector3 forceToApply;
    private float timeSinceLastForce;
    private float intervalTime;

    [SerializeField]private Vector3 speed;
    private IMovementStrategy movementStrategy;
    private Player player;
    void Start()
    {
        forceToApply = new Vector3(0, 0, 10);
        timeSinceLastForce = 0f;
        intervalTime = 2f;

        
        player = new Player(speed.x,speed.y);
        // SetMovementStrategy(new SmootMovement());
        SetMovementStrategy(new AcelerateMovement());


    }
    public void Update()
    {



    }

    public void MovePlayer(float input)
    {
        movementStrategy.Move(transform, player, input);
    }

    void FixedUpdate()
    {
        timeSinceLastForce += Time.fixedDeltaTime;
        if (timeSinceLastForce >= intervalTime)
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(forceToApply);
            timeSinceLastForce = 0f;
        }
    }


    public void SetMovementStrategy(IMovementStrategy movementStrategy)
    {
        this.movementStrategy = movementStrategy;


    }


}