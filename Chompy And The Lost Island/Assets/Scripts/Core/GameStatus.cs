using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStatus : MonoBehaviour
{
    protected int score = 0;

    static GameStatus instance;
    
    public static GameStatus GetInstance()
    {
        return instance;
    }

    void Start()
    {
        if(instance != null)
        {
            Destroy(this.gameObject);
            return;
        }

        instance = this;
        GameObject.DontDestroyOnLoad(this.gameObject);
    }

    public void AddScore(int s)
    {
        score += s;
    }

    public int GetScore()
    {
        return score;
    }

    public void ResetScore()
    {
        score = 0;
    }

}
