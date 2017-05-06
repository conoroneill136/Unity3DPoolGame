using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

    static int stripes;
    static int spots;
    static int black;

    static string winner;

    public Text GameEnd;
    public Text StripeRemaining;
    public Text SpotsRemaining;


    // Use this for initialization
    void Start () {

        stripes = 7;
        spots = 7;
        black = 1;
        SpotsRemaining.text = spots.ToString();
        StripeRemaining.text = stripes.ToString();		
	}
	
	// Update is called once per frame
	void Update () {
        updateScore();
        if (black == 0)
        {
            if (spots == 0)
            {
                GameEnd.text = "Spots Win";
            }
            else if (stripes == 0)
            {
                GameEnd.text = "Stripes Win";
            }
            else if(spots > 0 && stripes > 0 ){
                GameEnd.text = "Black Potted You Lose";
            }
            Time.timeScale = 0;

        }
    }

    public static void setScore(string typeOfBall) {
        if (typeOfBall == "Stripe")
        {
            stripes--;
        }
        if (typeOfBall == "Spot")
        {
            spots--;
        }
        if (typeOfBall == "Black")
        {
            black--;
        }
    }

    public void updateScore()
    {
        StripeRemaining.text = stripes.ToString();
        SpotsRemaining.text = spots.ToString();
    }



}
