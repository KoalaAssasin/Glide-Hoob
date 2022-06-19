using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalData : MonoBehaviour
{

    public Timer timerData;

    public Score scoreData;
    public int totalScore;

    public float totalTime;
    public float challengeTime;
    public float freeTime;

    public Text finalScore;
    public Text finalTime;
    public Text finalPercent;

    public float freePercent;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        totalTime = timerData.gameTime;
        freeTime = timerData.freeTime;
        totalScore = scoreData.scoreNumber;
        freePercent = (freeTime/totalTime)*100.0f;
        
        finalScore.text = totalScore.ToString();
        finalTime.text = totalTime.ToString();
        finalPercent.text = freePercent.ToString();

    }
}
