using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformActivate : MonoBehaviour
{
    public Material glowUp;
    

    // when the player touches the platforms, the platform will glow up
    void OnCollisionEnter(Collision col) {
        if (col.gameObject.tag == "Platform") {
            col.gameObject.GetComponent<Renderer>().material = glowUp;
        }
    }
}
