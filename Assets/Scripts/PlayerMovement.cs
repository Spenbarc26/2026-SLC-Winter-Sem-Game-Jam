using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections;
using System.Threading.Tasks;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpForce = 5f;

    public Transform groundCheck;
    public float groundDistance = 0.5f;
    public LayerMask groundMask;

    private Rigidbody2D rb;
    private Vector2 moveInput;
    public bool isGrounded = false;
    public float inputMove = 0.0f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //side to side movement
        if (Input.GetKeyDown(KeyCode.A))
        {
            inputMove = -1.0f;
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            inputMove = 1.0f;
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            inputMove = 0.0f;
        }
        rb.linearVelocity = new Vector2(inputMove * moveSpeed, rb.linearVelocity.y);

        CheckIsGrounded();

        //jump
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
        }
    }

    private void CheckIsGrounded()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundDistance, groundMask);
    }

    public void OnMovement(InputValue value)
    {
        moveInput = value.Get<Vector2>();
    }

    public void OnJump(InputValue value)
    {
        Debug.Log("Jump");
        if (isGrounded)
        {
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
    }
}
