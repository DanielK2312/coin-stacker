/*
Project 1
Author: Daniel Kosmin
Date: 2/9/22
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPrefab : MonoBehaviour
{
  private void OnCollisionEnter(Collision other)
  {
    // destroy coin prefab when it collides with the plane
    Destroy(other.collider.gameObject);
  }
}
