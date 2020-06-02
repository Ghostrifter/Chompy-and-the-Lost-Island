using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace chompyandthelostisland
{
    public class PlayerMovement : MonoBehaviour
    {
        public float moveSpeed;

        void FixedUpdate()
        {
            if(VirtualInputManager.Instance.MoveRight && VirtualInputManager.Instance.MoveLeft)
            {
                return;
            }

            if (VirtualInputManager.Instance.MoveRight)
            {
                this.gameObject.transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
                this.gameObject.transform.rotation = Quaternion.Euler(0f, 90f, 0f);
            }

            if (VirtualInputManager.Instance.MoveLeft)
            {
                this.gameObject.transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
                this.gameObject.transform.rotation = Quaternion.Euler(0f, 270f, 0f);
            }
        }
    }
}

