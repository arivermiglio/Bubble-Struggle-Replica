using UnityEngine;

public class Ball : MonoBehaviour
{
    public Vector2 startForce;

    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        // ForceMode2D.Impulse is the application of a force impulse (short time)
        // ForceMode2D.Force is a continuous force
        rb.AddForce(startForce, ForceMode2D.Impulse); 
    }

}
