using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    public int score = 10;
    public int rotationSpeed;

    private void OnTriggerEnter(Collider collider)
    {
        if(collider.gameObject.tag == "Player")
        {
            AudioManager.instance.Play("Collect");
            GameStatus.GetInstance().AddScore(score);
            Destroy(gameObject);
        }
    }

    void Update()
    {
        transform.Rotate(0, rotationSpeed, 0, Space.World);
    }
}
