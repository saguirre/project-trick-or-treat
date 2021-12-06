using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetScore : MonoBehaviour
{
    public Text totalScore;
    // Start is called before the first frame update
    void Start()
    {
        totalScore.text = "SCORE: " + Score.score;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
