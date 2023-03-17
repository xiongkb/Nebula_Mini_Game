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
            Counter.activatedScore = 0;
            SceneManager.LoadScene(loadScene);
        }
    }
}
