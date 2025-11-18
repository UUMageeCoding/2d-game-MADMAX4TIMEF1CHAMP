using UnityEngine;

public class MoveBetweenTwoPoints : MonoBehaviour
{
    public float enemySpeed = 1f;

    private Rigidbody2D rb;
    private SpriteRenderer sr;

    private bool isFacingRight = false;   // Start moving left

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();

        rb.freezeRotation = true;
    }

    void FixedUpdate()
    {
        // Move the slime left or right using physics
        float direction = isFacingRight ? 1f : -1f;
        rb.linearVelocity = new Vector2(direction * enemySpeed, rb.linearVelocity.y);

        // Flip sprite using SpriteRenderer
        sr.flipX = !isFacingRight;  // flipX = true when facing left
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // When the slime hits a "Solid" wall, reverse direction
        if (collision.gameObject.CompareTag("solid"))
        {
            isFacingRight = !isFacingRight;
        }
    }
}