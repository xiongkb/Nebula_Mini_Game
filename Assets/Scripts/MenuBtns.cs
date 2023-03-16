using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuBtns : MonoBehaviour
{
    public int startButton;
    public int creditButton;

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
}
