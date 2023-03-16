using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Respawn : MonoBehaviour
{
    
    void OnTriggerEnter(Collider other) {
        if(other.gameObject.tag == "Player"){
            // grab current scene and reload scene when player "fails" and it will refresh the whole level
            Scene currentScene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(currentScene.name);
        }
    }
}
