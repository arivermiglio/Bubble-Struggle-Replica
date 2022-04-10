using UnityEngine;

public class Ball : MonoBehaviour
{
    public Vector2 startForce;

    public GameObject nextBall;

    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        // ForceMode2D.Impulse is the application of a force impulse (short time)
        // ForceMode2D.Force is a continuous force
        rb.AddForce(startForce, ForceMode2D.Impulse); 
    }

    public void Split()
    {
        if (nextBall != null)
        {
            // use rb.position instead of transform.position because
            // rb.position gives position in x and y (Vector2)
            // while transform.position always gives a Vector3 (x, y, z). 
            // Quaternion.identity means no rotation
            // add tiny vectors to rb.position so the two new balls spawn in slightly
            // diffrent positions
            Instantiate(nextBall, rb.position + Vector2.right / 4f, Quaternion.identity);
            Instantiate(nextBall, rb.position + Vector2.left / 4f, Quaternion.identity);
        }
        // Destroy the old ball
        Destroy(gameObject);
    }
}
