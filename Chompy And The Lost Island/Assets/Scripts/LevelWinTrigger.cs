using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelWinTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider collider)
    {
        if(collider.gameObject.tag == "Player")
        {
            AudioManager.instance.Play("GameWin");
            FindObjectOfType<GameWonMenu>().GameWon();
        }
    }
}
