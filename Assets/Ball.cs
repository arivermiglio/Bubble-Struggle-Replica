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
            GameObject ball1 = Instantiate(nextBall, rb.position + Vector2.right / 4f, Quaternion.identity);
            GameObject ball2 = Instantiate(nextBall, rb.position + Vector2.left / 4f, Quaternion.identity);

            // let the new balls have upward momentum to appear lively
            ball1.GetComponent<Ball>().startForce = new Vector2(2f, 5f);
            ball2.GetComponent<Ball>().startForce = new Vector2(-2f, 5f);
        }
        else
        {
            Debug.Log("Game Over");
        }
    // Destroy the old ball
    Destroy(gameObject);
}
}
