/* 
    ==================================
    DIG3878 Spring 2023
    Kang Xiong
    Assignment: Midterm
    This file name: QuitGame.cs
    ==================================
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitGame : MonoBehaviour {

	// Update is called once per frame
	public void Update () {
        if (Input.GetKey("escape"))
            Application.Quit();
	}
}