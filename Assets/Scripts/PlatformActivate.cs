using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformActivate : MonoBehaviour
{
    public Material glowUp;
    public AudioClip soundEffect;
    
    AudioSource audioSrc;

    void Start()
    {
        audioSrc = GetComponent<AudioSource>();
    }

    // when the player touches the platforms, the platform will glow up
    void OnCollisionEnter(Collision col) {
        if (col.gameObject.tag == "Platform" && col.gameObject.GetComponent<Renderer>().material != glowUp){
            audioSrc.PlayOneShot(soundEffect);
            col.gameObject.GetComponent<Renderer>().material = glowUp;
        }
    }
}
