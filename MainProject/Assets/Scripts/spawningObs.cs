﻿using UnityEngine;
using System.Collections;

[RequireComponent (typeof(Rigidbody2D))]
public class spawningObs : MonoBehaviour {

	//this holds the spawning process of the obstacle and food for the turtle

	public static spawningObs gm;
	public GameObject prefabOfObstacle;
	public GameObject prefabOfFood;
	public Transform spawnPoint1;
	public Transform spawnPoint2;
	public float min, max;
	public bool colToObs = false;
	// Use this for initialization
	void Start () {
		if(gm == null){
			gm = GameObject.FindGameObjectWithTag ("spawn1").GetComponent<spawningObs>();
		}
		gm.StartCoroutine (gm.spawnObjects());
	}


	private IEnumerator spawnObjects (){

		while (colToObs == false) {
			float obj = Random.Range (min,max);
			float lane = Random.Range (0f,2.0f);

			yield return new WaitForSeconds (obj);
			if (lane < 1.0f) {
				if (obj < (min + max) / 2) {
					createObject(prefabOfFood,spawnPoint1);

				} else {
					createObject(prefabOfObstacle,spawnPoint1);
				}
			} else {
				if (obj < (min + max) / 2) {
					createObject(prefabOfFood,spawnPoint2);
				} else {
					createObject(prefabOfObstacle,spawnPoint2);
				}
			}
		}
	}

	void createObject (GameObject o, Transform p){
		Instantiate (o, p.position, o.transform.rotation);
	}
	
}
