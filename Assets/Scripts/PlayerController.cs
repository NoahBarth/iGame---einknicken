using UnityEditor.Tilemaps;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5;
    public int facingDirection = 1;
    public Rigidbody2D rb;

    public Animator anim;

    public bool hasKey = false;

    // Update is called 50x per second
    void FixedUpdate()
    {
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

    void Flip()
    {
        facingDirection *= -1;
        transform.localScale = new Vector3(transform.localScale.x * -1, transform.localScale.y, transform.localScale.z);
    }
}
