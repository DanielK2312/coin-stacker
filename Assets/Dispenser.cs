/*
Project 1
Author: Daniel Kosmin
Date: 2/9/22
*/

using UnityEngine;

public class Dispenser : MonoBehaviour
{

  // instance of coin being dispensed
  public GameObject CoinPrefab;
  // get position of end of shooter
  public Transform shooterEnd;

  bool spawned = false;
  float decay;

  // Update is called once per frame
  void Update()
  {

    //counter += 1;
    //if (counter % 30 == 0) // 2 per second
    //{
    //    // place the prefab where end of shooter is
    //    // everytime a new coin is created, it comes out of the end of the shooter
    //    GameObject coin = Instantiate(coinPrefab, shooterEnd.position, Quaternion.identity);
    //    Rigidbody coinBody = coin.GetComponent<Rigidbody>();
    //    coinBody.AddForce(new Vector3(0, 1, 0), ForceMode.Impulse);
    //}

    Reset();

    if (Input.GetKeyDown(KeyCode.Space) && !spawned)
    {
      GameObject coin = Instantiate(CoinPrefab, shooterEnd.position, Quaternion.identity);
      Rigidbody coinBody = coin.GetComponent<Rigidbody>();
      coinBody.AddForce(new Vector3(0, 1, 0), ForceMode.Impulse);
      // make drag randomly change between 1 and 5
      // coinBody.drag = Random.Range(1, 5);
      coinBody.drag = 1;
    }

  }


  private void Reset()
  {
    if (spawned && decay > 0)
    {
      decay -= Time.deltaTime;
    }
    if (decay < 0)
    {
      spawned = false;
    }
  }

}
