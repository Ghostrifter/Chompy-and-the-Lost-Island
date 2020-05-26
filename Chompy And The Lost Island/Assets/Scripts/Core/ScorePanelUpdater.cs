using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScorePanelUpdater : MonoBehaviour
{
    void Update()
    {
        GetComponent<Text>().text = "Score: " + GameStatus.GetInstance().GetScore();
    }
}
