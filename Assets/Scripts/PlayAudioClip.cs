/* 
    ==================================
    DIG3878 Spring 2023
    Kang Xiong
    Assignment: Midterm
    This file name: PlayAudioClip.cs
    ==================================
*/

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

    //play sound clip when the platform glows up and only once
    void OnCollisionEnter(Collision col){
        if(col.gameObject.tag == "Player" && !activated){
            audioSrc.PlayOneShot(soundClip);
            activated = true;
            Counter.activatedScore++;
        }
        
    }
    
}
