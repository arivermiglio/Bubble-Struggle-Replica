using UnityEngine;

public class Player : MonoBehaviour
{
    //[HideInInspector]
    public float speed = 4f;

    public Rigidbody2D rb;

    public float movement = 0f;

    void Update()
    {
        // change "GetAxisRaw" to "GetAxis" for smoother movement
        movement = Input.GetAxis("Horizontal") * speed;
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + new Vector2(movement * Time.fixedDeltaTime, 0f));

    }
}
