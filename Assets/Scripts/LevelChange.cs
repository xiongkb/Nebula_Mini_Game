/* 
    ==================================
    DIG3878 Spring 2023
    Kang Xiong
    Assignment: Midterm
    This file name: LevelChange.cs
    ==================================
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChange : MonoBehaviour
{
    public int sceneIndex;

    //when the sun is touched go to next level
    void OnTriggerEnter(Collider col) {
        if(col.gameObject.tag == "Player"){
            SceneManager.LoadScene(sceneIndex);
        }
    }
}
