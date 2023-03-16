using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuBtns : MonoBehaviour
{
    public int startButton;
    public int quitButton;
    public int creditButton;
    // load scene based on scene index
    void StartBtn(){
        SceneManager.LoadScene(startButton);
    }

    void QuitBtn(){
        SceneManager.LoadScene(quitButton);
    }

    void CreditBtn(){
        SceneManager.LoadScene(creditButton);
    }
}
