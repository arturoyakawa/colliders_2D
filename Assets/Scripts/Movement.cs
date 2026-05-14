using UnityEngine;

public class Movement : MonoBehaviour
{
    //fR = facing right
    //tS = the scale
    private Rigidbody2D rb;
    private float horizontal;
    private float vertical;

    [SerializeField]
    private float movementSpeed;
    private float jumpPower;
    private bool fR;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        movementSpeed = 10f;
        rb = GetComponent<Rigidbody2D>();

        jumpPower = 14f;
        fR = true;
    }
    private bool IsGrounded()
    {
        return true;
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        
        handMovement(horizontal);
    }

    void handMovement(float horizontal)
    {
        rb.linearVelocity = new Vector2(horizontal * movementSpeed, rb.linearVelocity.y);
    }

    private void FixedUpdate()
    {
        flip(horizontal);
        if (vertical > 0)
        {
            Jump();
        }
    }

    void flip(float horizontal)
    {
        if (horizontal > 0 && !fR || horizontal < 0 && fR)
        {
            fR = !fR;
            Vector2 tS = transform.localScale;

            tS.x *= -1;

            transform.localScale = tS;
         }
    }

    void Jump()
    {
        rb.linearVelocityY = vertical * jumpPower;
    }

    void OnCollisionEnter2D()
    {
        
    }

    void OnCollisionExit2D()
    {

    }
}