using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{
    public static int activatedScore = 0;
    public int lvlAmount;
    public TextMeshProUGUI scoreText;


    //to next level, spawn the "sun"
    public GameObject theSun;

    void Start(){
        activatedScore = 0;
    }
    // Update is called once per frame
    void Update()
    {
        scoreText.text = "activated: " + activatedScore + "/" + lvlAmount;

        //turn on the sun
        if(activatedScore >= lvlAmount){
            theSun.SetActive(true);
        }
    }

    
}
