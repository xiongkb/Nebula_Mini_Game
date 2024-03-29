/* 
    ==================================
    DIG3878 Spring 2023
    Kang Xiong
    Assignment: Midterm
    This file name: ActivateTexts.cs
    ==================================
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateTexts : MonoBehaviour
{
    public GameObject displayText;
    private bool alreadyDisplayed = false;

    void OnCollisionEnter(Collision col){
        if(col.gameObject.tag == "Player" && !alreadyDisplayed){
            displayText.SetActive(true);
            alreadyDisplayed = true;
        }
    }

    void OnCollisionExit(Collision col){
        if(col.gameObject.tag == "Player" && alreadyDisplayed){
            Destroy(displayText);
        }
    }
}
