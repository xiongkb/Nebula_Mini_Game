using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChange : MonoBehaviour
{
    public int sceneIndex;

    void OnTriggerEnter(Collider col) {
        if(col.gameObject.tag == "Player"){
            SceneManager.LoadScene(sceneIndex);
        }
    }
}
