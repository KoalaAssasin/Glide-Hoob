using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    public int scoreNumber = 0;
    public Text scoreText;


    void Update() {
            scoreText.text = scoreNumber.ToString();    
    }

}
