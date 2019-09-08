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
        if (Input.GetKeyUp("space") && grounded)
        {
            rb.AddRelativeForce(transform.up * jumpThrust, ForceMode2D.Impulse);
        }
    }

    private void Slide()
    {
        if (Input.GetKey("down") && !isSliding)
        {
            col.size = colSizeSmall;
            isSliding = true;
        }
        if (Input.GetKeyUp("down") && isSliding)
        {
            col.size = colSizeNormal;
            isSliding = false;
        }
    }
}