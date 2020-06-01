using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelMenu : MenuCore
{
    public void PlayLevel1()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Level_1");
    }
}
