using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace chompyandthelostisland
{
    public class VirtualInputManager : MonoBehaviour
    {
        public static VirtualInputManager Instance;

        private void Awake()
        {
            if(Instance == null)
            {
                Instance = this;
            }
            else if(Instance != this)
            {
                Destroy(this.gameObject);
            }
        }

        public bool MoveRight;
        public bool MoveLeft;
    }
}

