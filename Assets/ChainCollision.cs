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
            // Split ball in two

        }
    }
}
