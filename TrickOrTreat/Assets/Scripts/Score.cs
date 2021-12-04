using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    private int score;
    public Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "Candy")
        {
            score++;
            scoreText.text = "Score: "+score;
            Debug.Log("Score: " + score);
        }
    }

}
