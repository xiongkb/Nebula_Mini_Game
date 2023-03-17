using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudioClip : MonoBehaviour
{
    public AudioClip soundClip;
    AudioSource audioSrc;
    
    bool activated = false;

    void Start()
    {
        audioSrc = GetComponent<AudioSource>();
    }

    void OnCollisionEnter(Collision col){
        if(col.gameObject.tag == "Player" && !activated){
            audioSrc.PlayOneShot(soundClip);
            activated = true;
            Counter.activatedScore++;
        }
        
    }
    
}
