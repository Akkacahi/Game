using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelManagement : MonoBehaviour
{
    public Text highscoretxt;

    public void Start()
    {
       int highscore = PlayerPrefs.GetInt("Highscore");
        highscoretxt.text = "HighScore =  " + highscore.ToString();
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("Game");

    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
            Debug.Log("?????????");
        }
    }


}
