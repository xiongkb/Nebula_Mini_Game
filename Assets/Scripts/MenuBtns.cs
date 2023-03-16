using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuBtns : MonoBehaviour
{
    public int startButton;
    public int creditButton;

    public static string currentScene;
    public static string previousScene;
    private string gameOver = "Game_Over";

    void Start(){
        Scene scene = SceneManager.GetActiveScene();
        Debug.Log("Current Scene is: " + scene.name);
        currentScene = scene.name;
        if (currentScene != gameOver){
            
            previousScene = currentScene;
            Debug.Log("Previous Scene is: " + previousScene);
        }
    }

    // load scene based on scene index and menu btns
    public void StartBtn(){
        SceneManager.LoadScene(startButton);
    }

    public void QuitBtn(){
        Debug.Log("Clicked Quit");
        Application.Quit();
    }

    public void CreditBtn(){
        SceneManager.LoadScene(creditButton);
    }

    public void TryAgain(){
        Debug.Log(previousScene);
       SceneManager.LoadScene(previousScene);
    }
}
