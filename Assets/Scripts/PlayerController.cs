using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody rb;
    public float speed = 5f;
    public float jumpHeight = 2f;

    private bool canJump;
    private bool isJumping = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (canJump)
            {
                isJumping = true;
            }
        }
    }

    private void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 forceVector = new Vector3(moveHorizontal, 0.0f, moveVertical);
        rb.AddForce(forceVector * speed);

        if (isJumping)
        {
            rb.AddForce(0.0f, jumpHeight, 0.0f, ForceMode.Impulse);
            isJumping = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Floor")
        {
            canJump = true;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Floor")
        {
            canJump = false;
        }
    }
}
