using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoubleJump : MonoBehaviour
{
    public float jumpForce = 5f;
    public int defaultJumpAllowed = 1;
    int jumpAllowed;

    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;

    Rigidbody rig;
    bool isGrounded;

    void Start()
    {
        rig = GetComponent<Rigidbody>();
        jumpAllowed = defaultJumpAllowed;
    }

    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if (Input.GetButtonDown("Jump"))
        {
            if (isGrounded)
            {
                Jump();
                jumpAllowed = defaultJumpAllowed;
            }
            else if (!isGrounded && jumpAllowed > 0)
            {
                Jump();
                jumpAllowed--;
            }
        }
    }

    private void Jump()
    {
        rig.AddForce(Vector3.up * jumpForce, ForceMode.VelocityChange);
        AudioManager.instance.Play("PlayerJump");
    }
}
