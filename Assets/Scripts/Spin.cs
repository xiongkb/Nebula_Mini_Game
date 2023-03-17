/* 
    ==================================
    DIG3878 Spring 2023
    Kang Xiong
    Assignment: Midterm
    This file name: Spin.cs
    ==================================
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour
{
    public int rotateSpeed;

    // rotate star along the y-axis
    void Update()
    {
        transform.RotateAround(transform.position, transform.up, Time.deltaTime * rotateSpeed);
    }
}
