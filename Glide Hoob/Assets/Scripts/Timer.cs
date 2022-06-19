using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{

    public TMP_Text TimeUI;
    public GameObject uiTimerCanvas;
    public GameObject uiSwitchCanvas;
    public float gameTime = 0;
    bool timerShown = false;
    bool countingTime = true;
    bool challengeMode = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
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

        if (countingTime == true)
        {
            gameTime += Time.deltaTime;
        }

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
        else if (Input.GetKeyDown(KeyCode.E) && countingTime == false)
        {
            uiSwitchCanvas.SetActive(false);
            countingTime = true;
        }

    }
}
