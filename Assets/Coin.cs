/*
Project 1
Author: Daniel Kosmin
Date: 2/9/22
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
  // Start is called before the first frame update
  void Start()
  {

    gameObject.GetComponent<Renderer>().material.color = Color.red;

    // destroy coin after 8 seconds
    // Destroy(gameObject, 8);
  }

}
