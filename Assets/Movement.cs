/*
Project 1
Author: Daniel Kosmin
Date: 2/9/22
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

  public float traySpeed = 20.0f;

  // Update is called once per frame
  void Update()
  {

    Vector3 pos = transform.position;

    if (Input.GetKey("w"))
    {
      pos.z += traySpeed * Time.deltaTime;
    }
    if (Input.GetKey("s"))
    {
      pos.z -= traySpeed * Time.deltaTime;
    }
    if (Input.GetKey("d"))
    {
      pos.x += traySpeed * Time.deltaTime;
    }
    if (Input.GetKey("a"))
    {
      pos.x -= traySpeed * Time.deltaTime;
    }


    transform.position = pos;

  }

}
