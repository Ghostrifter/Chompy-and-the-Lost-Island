using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    public int score = 10;

    private void OnTriggerEnter(Collider collider)
    {
        if(collider.gameObject.tag == "Player")
        {
            AudioManager.instance.Play("Collect");
            GameStatus.GetInstance().AddScore(score);
            Destroy(gameObject);
        }
    }
}
