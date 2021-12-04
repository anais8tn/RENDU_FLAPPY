using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    public int myScore;

    public void addScore()
    {
        myScore++;
        GetComponent<TextMeshProUGUI>().text = myScore.ToString();
        Debug.Log("Add score");
    }

    public void resetScore()
    {
        myScore = 0;
        GetComponent<TextMeshProUGUI>().text = myScore.ToString();
    }

}
