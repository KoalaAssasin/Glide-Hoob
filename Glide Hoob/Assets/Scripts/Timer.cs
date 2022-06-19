using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{

    public TMP_Text TimeUI;
    public GameObject uiTimerCanvas;
    public float gameTime = 0;
    bool timerShown = false;

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

        //TimeUI.text += Time.deltaTime.ToString();
        TimeUI.text = gameTime.ToString();
        gameTime += Time.deltaTime;

    }
}
