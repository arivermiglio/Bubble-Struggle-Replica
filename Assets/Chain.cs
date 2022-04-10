using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chain : MonoBehaviour
{
    public static bool IsFired;

    public Transform player;

    public float speed = 2f;

    private void Start()
    {
        IsFired = false;
    }

    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            IsFired = true;
        }

        if (IsFired)
        {
            transform.localScale =transform.localScale +  Vector3.up * Time.deltaTime * speed;
        }
        else
        {
            transform.position = player.position;
            // y is 0 so the chain won't show up
            transform.localScale = new Vector3(1f, 0f, 1f);
        }
    }
}
