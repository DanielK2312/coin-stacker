/*
Project 1
Author: Daniel Kosmin
Date: 2/9/22
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI; //for NavMeshAgent

public class CubeMovement : MonoBehaviour
{
  private NavMeshAgent nma = null;
  private GameObject[] RandomPoint;
  private int CurrentRandom;

  private void Start()
  {
    nma = this.GetComponent<NavMeshAgent>();
    RandomPoint = GameObject.FindGameObjectsWithTag("RandomPoint");
    // Debug.Log("RandomPoints = " + RandomPoint.Length.ToString());
  }

  private void Update()
  {
    if (nma.hasPath == false)
    {
      CurrentRandom = Random.Range(0, RandomPoint.Length + 1);
      nma.SetDestination(RandomPoint[CurrentRandom].transform.position);
      //   Debug.Log("Moving to RandomPoint " + CurrentRandom.ToString());
    }
  }
}
