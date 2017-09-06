using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public Transform[] spawnPoint;
    public GameObject punpikin;

	// Use this for initialization
	void Start () {
        StartCoroutine(StartSpawning());
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    IEnumerator StartSpawning()
    {
        yield return new WaitForSeconds(Random.Range(1f,3.5f));
        Instantiate(punpikin, spawnPoint[Random.Range(0, spawnPoint.Length)].position, Quaternion.identity);
        StartCoroutine(StartSpawning());
    }
}
