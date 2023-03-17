/* 
    ==================================
    DIG3878 Spring 2023
    Kang Xiong
    Assignment: Midterm
    This file name: CursorVisibility.cs
    ==================================
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CursorVisibility : MonoBehaviour
{
    void Start(){
        Scene scene = SceneManager.GetActiveScene();

        //show mouse cursor on menu scenes and hides on gameplay scenes
        if(scene.name == "ThankYou" || scene.name == "Game_Over" || scene.name == "Start_Menu"){
           Cursor.lockState = CursorLockMode.Confined;
            Cursor.visible = true; 
        } else {
           Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false; 
        }
        
    }
}
