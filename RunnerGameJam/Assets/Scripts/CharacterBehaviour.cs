using UnityEngine;

public class CharacterBehaviour : MonoBehaviour
{
    Rigidbody2D rb;

    [SerializeField]
    private float jumpThrust;
    private bool grounded;

    private BoxCollider2D col;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        grounded = true;
    }

    void Update()
    {
        Jump();
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

    private void Duck()
    {
        if (Input.GetKey("space"))
        {
            col.size = new Vector3();
        }

    }
}
