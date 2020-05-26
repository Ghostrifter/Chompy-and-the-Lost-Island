using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutOfMapTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            FindObjectOfType<Player>().Die();
        }
    }
}
