
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5;
    public int facingDirection = 1;
    public Rigidbody2D rb;

    public Animator anim;

    public bool hasKey = false;

    public TimeIndicator timeIndicatorEventGenerator;

    private ContactFilter2D ContactFilter;

    public bool IsGrounded => rb.IsTouching(ContactFilter);
    private Vector3 climbDirection;
    public bool onLadder = false;

    void OnEnable()
    {
        timeIndicatorEventGenerator.EventclimbTrigger += Climb;
    }

    void OnDisable()
    {
        timeIndicatorEventGenerator.EventclimbTrigger -= Climb;
    }

    // Update is called 50x per second
    void FixedUpdate()
    {
        if (IsGrounded && onLadder)
        {
            gameObject.GetComponent<Rigidbody2D>().gravityScale = 0;
            onLadder = false;
        }
        // Debug.Log("Is not on FLoor :"+IsGrounded);
        if(!onLadder) {
            if(IsGrounded) gameObject.GetComponent<Rigidbody2D>().gravityScale = 0;
            float horizontalInput = Input.GetAxis("Horizontal");
            // float verticalInput = Input.GetAxis("Vertical");

            if(horizontalInput > 0 && transform.localScale.x < 0 ||
            horizontalInput < 0 && transform.localScale.x > 0)
            {
                Flip();
            }

            anim.SetFloat("horizontal", Mathf.Abs(horizontalInput));

            rb.linearVelocity = new Vector2(horizontalInput, 0) * speed;
        }
    }

    void Flip()
    {
        facingDirection *= -1;
        transform.localScale = new Vector3(transform.localScale.x * -1, transform.localScale.y, transform.localScale.z);
    }


    // Event listener on TimeBar full
    void Climb()
    {
            transform.Translate(climbDirection * Time.deltaTime * 3, Space.World);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.GetComponent<Ladder>())
        {
            if (collision.GetComponent<Ladder>().ladderToggle) 
            {
                climbDirection = Vector3.up;
            }
            else if (!collision.GetComponent<Ladder>().ladderToggle) 
            {
                climbDirection = Vector3.down;
            }
        }
    }
}
