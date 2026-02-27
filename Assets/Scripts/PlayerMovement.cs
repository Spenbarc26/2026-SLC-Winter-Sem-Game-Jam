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
        CheckGround();
        if (transform.position.x <= -97.3 && moveInput.x == -1)
        {
            transform.Translate(new Vector3(1, 0, moveInput.y) * Time.deltaTime * moveSpeed);
        }
        else if (transform.position.x >= 102.25 && moveInput.x == 1)
        {
            transform.Translate(new Vector3(-1, 0, moveInput.y) * Time.deltaTime * moveSpeed);
        }
            transform.Translate(new Vector3(moveInput.x, 0, moveInput.y) * Time.deltaTime * moveSpeed);
    }

    private void CheckGround()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundDistance, groundMask);
    }

    public void OnMovement(InputValue value)
    {
        moveInput = value.Get<Vector2>();
    }

    public void OnJump(InputValue value)
    {
        if (isGrounded)
        {
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
    }
}
