using UnityEngine;

public class Movement : MonoBehaviour
{

    private Rigidbody2D rb;
    private float horizontal;

    [SerializeField] private float movementSpeed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        movementSpeed = 10f;
        rb = GetComponent<Rigidbody2D>();
    }
 
    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        Debug.Log(horizontal);
        handMovement(horizontal);
    }

    void handMovement(float horizontal)
    {
        
    }

}