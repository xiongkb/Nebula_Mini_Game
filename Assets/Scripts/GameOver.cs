/* 
    ==================================
    DIG3878 Spring 2023
    Kang Xiong
    Assignment: Midterm
    This file name: GameOver.cs
    ==================================
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public string loadScene;
    
    void OnTriggerEnter(Collider other) {
        if(other.gameObject.tag == "Player"){
            // go to gameover screen menu
            SceneManager.LoadScene(loadScene);
        }
    }
}
