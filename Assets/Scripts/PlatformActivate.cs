using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformActivate : MonoBehaviour
{
    public Material glowUp;

    void OnCollisionEnter(Collision other) {
        if (other.gameObject.tag == "Platform"){
            Debug.Log("Touched platform: " + other);
        }
    }
}
