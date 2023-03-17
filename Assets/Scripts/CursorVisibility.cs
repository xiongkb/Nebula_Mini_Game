using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CursorVisibility : MonoBehaviour
{
    void Start(){
        Scene scene = SceneManager.GetActiveScene();
        // if(scene.name == "Level_01"){
        //    Cursor.lockState = CursorLockMode.Locked;
        //     Cursor.visible = false; 
        // } else {
        //    Cursor.lockState = CursorLockMode.Confined;
        //     Cursor.visible = true; 
        // }

        if(scene.name == "ThankYou" || scene.name == "Game_Over" || scene.name == "Start_Menu"){
           Cursor.lockState = CursorLockMode.Confined;
            Cursor.visible = true; 
        } else {
           Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false; 
        }
        
    }
}
