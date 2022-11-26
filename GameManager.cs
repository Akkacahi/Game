using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public int score = 0;
    public Text Scoretxt;
    
    // Update is called once per frame
    void Update()
    {
        Scoretxt.text = "Score = " + score.ToString();
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
            Debug.Log("?????????");
        }
    }

    public void killEnemy()
    {
        score += 10;
        if (score>=PlayerPrefs.GetInt("Highscore",0)) //Point
        {
            PlayerPrefs.SetInt("Highscore", score);
        }
    }
}
