using UnityEngine;
using System.Collections;

public class GM : MonoBehaviour {

	public static int score = 0;
	// Use this for initialization
	void Start () {
		score = 0;
	}
	
	// Update is called once per frame
	public static void AddScore (string obj) {
		if (obj == "food")
			score += 1;
		Debug.Log ("score is : " +score);
	}
}
