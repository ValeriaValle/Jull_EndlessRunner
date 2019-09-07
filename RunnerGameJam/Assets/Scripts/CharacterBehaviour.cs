using UnityEngine;

public class CharacterBehaviour : MonoBehaviour
{
    Rigidbody2D rb;

    [SerializeField]
    private float jumpThrust;
    private bool grounded;

    [SerializeField]
    private Vector2 colSizeSmall;
    private Vector2 colSizeNormal;
    private BoxCollider2D col;
    private bool isSliding;

    void Start()
    {
        rb = GetComponentInChildren<Rigidbody2D>();
        col = GetComponentInChildren<BoxCollider2D>();
        colSizeNormal = col.size;
        grounded = true;
        isSliding = false;
    }

    void Update()
    {
        Jump();
        Slide();
    }

    void OnCollisionStay2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Terrain"))
        {
            grounded = true;
        }
    }

    void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Terrain"))
        {
            grounded = false;
        }
    }

    private void Jump()
    {
        if (Input.GetKeyDown("space") && grounded)
        {
            rb.AddForce(transform.up * jumpThrust);
        }
    }

    private void Slide()
    {
        if (Input.GetKey("space") && !isSliding)
        {
            col.size = colSizeSmall;
            isSliding = true;
            //transform.localScale = new Vector3();
        }
        if (Input.GetKeyUp("space") && isSliding)
        {
            col.size = colSizeNormal;
            isSliding = false;
        }
    }
}