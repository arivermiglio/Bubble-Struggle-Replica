using UnityEngine;

public class ChainCollision : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col)
    {
        // Debug.Log("HIT");
        // reset the chain
        Chain.IsFired = false;

        if (col.tag == "Ball")
        {
            // col refers to the old Ball obj
            // Split ball in two
            col.GetComponent<Ball>().Split();
        }
    }
}
