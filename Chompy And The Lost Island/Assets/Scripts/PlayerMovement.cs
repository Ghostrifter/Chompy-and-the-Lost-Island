using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace chompyandthelostisland
{
    public class PlayerMovement : MonoBehaviour
    {
        public float moveSpeed;
        public Animator animator;

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

        void FixedUpdate()
        {
            if(VirtualInputManager.Instance.MoveRight && VirtualInputManager.Instance.MoveLeft)
            {
                animator.SetBool("Move", false);
                return;
            }

            if (!VirtualInputManager.Instance.MoveRight && !VirtualInputManager.Instance.MoveLeft)
            {
                animator.SetBool("Move", false);
            }

            if (VirtualInputManager.Instance.MoveRight)
            {
                this.gameObject.transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
                this.gameObject.transform.rotation = Quaternion.Euler(0f, 90f, 0f);
                animator.SetBool("Move", true);
            }

            if (VirtualInputManager.Instance.MoveLeft)
            {
                this.gameObject.transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
                this.gameObject.transform.rotation = Quaternion.Euler(0f, 270f, 0f);
                animator.SetBool("Move", true);
            }
        }

        void Update()
        {
            isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

            /*if(isGrounded == true && rig.velocity.magnitude > 2f && GetComponent<AudioSource>().isPlaying == false)
            {
                GetComponent<AudioSource>().Play();
            }*/

            if (isGrounded)
            {
                animator.SetBool("Jump", false);
            }

            if (!isGrounded)
            {
                animator.SetBool("Jump", true);
            }

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
}

