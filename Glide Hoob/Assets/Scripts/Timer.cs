using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{

    public TMP_Text TimeUI;
    public GameObject uiTimerCanvas;
    public GameObject uiSwitchCanvas;
    public GameObject uiEndCanvas;
    bool endGame;
    public float gameTime = 0;

    public float freeTime = 0;
    public float challengeTime = 0;

    bool timerShown = false;
    bool countingTime = true;

    public GameObject enemies;
    public GameObject scoreText;
    bool challengeMode = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Switches time counter visibility
        if (Input.GetKeyDown(KeyCode.T) && timerShown == false)
        {
            uiTimerCanvas.SetActive(true);
            timerShown = true;
        }
        else if (Input.GetKeyDown(KeyCode.T) && timerShown == true)
        {
            uiTimerCanvas.SetActive(false);
            timerShown = false;
        }

        TimeUI.text = gameTime.ToString();

        //Changes if it is counting or not
        if (countingTime == true)
        {
            gameTime += Time.deltaTime;

            if(challengeMode == true)
            {
                challengeTime += Time.deltaTime;
            }
            else if(challengeMode == false)
            {
                freeTime += Time.deltaTime;
            }
        }


        //Brings up the switch canvas or hides it
        if (Input.GetKeyDown(KeyCode.E) && countingTime == true)
        {
            if(timerShown == false)
            {
                uiTimerCanvas.SetActive(true);
                timerShown = true;
            }

            uiSwitchCanvas.SetActive(true);
            countingTime = false;
        }
        //Closes out of switch menu without changing anything
        else if (Input.GetKeyDown(KeyCode.E) && countingTime == false)
        {
            uiSwitchCanvas.SetActive(false);
            countingTime = true;
        }

        //closes out of switch menu while changing mode
        else if(Input.GetKeyDown(KeyCode.Y) && countingTime == false)
        {
            if(challengeMode == true)
            {
                challengeMode = false;
            }
            else if(challengeMode == false)
            {
                challengeMode = true;
            }
            uiSwitchCanvas.SetActive(false);
            countingTime = true;
        }

        if(challengeMode == false)
        {
            enemies.SetActive(false);
            scoreText.SetActive(false);
        }
        else
        {
            enemies.SetActive(true);
            scoreText.SetActive(true);
        }

        //Brings up end game menu
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            countingTime = false;
            uiEndCanvas.SetActive(true);
            endGame = true;
        }

        //Closes game if player is in end game menu
        if(endGame == true && Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }

    }
}
