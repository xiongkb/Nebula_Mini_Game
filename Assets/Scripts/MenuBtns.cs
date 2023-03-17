/* 
    ==================================
    DIG3878 Spring 2023
    Kang Xiong
    Assignment: Midterm
    This file name: MenuBtns.cs
    ==================================
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuBtns : MonoBehaviour
{
    public static string currentScene;
    public static string previousScene;
    private string gameOver = "Game_Over";

    void Start(){
        Scene scene = SceneManager.GetActiveScene(); //get current scene
        currentScene = scene.name;

        //setting the scene for the previous gameplay scene
        if (currentScene != gameOver){
            previousScene = currentScene;
        }
    }

    // load scene based on scene index and menu btns
    public void QuitBtn(){
        Application.Quit();
    }

    public void LoadByIndex(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }

    //restart from the beginning of the gameplay level where player gameover'ed
    public void TryAgain(){
       SceneManager.LoadScene(previousScene);
    }

    
}
