/*
Project 1
Author: Daniel Kosmin
Date: 2/9/22
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeCollision : MonoBehaviour
{

  public float counter = 0.0f;
  public UnityEngine.UI.Text scoreText;

  private void OnCollisionEnter(Collision other)
  {
    counter += 1;
    Debug.Log(counter);
    // update and display score on every collision
    scoreText.text = counter.ToString();
  }
}
