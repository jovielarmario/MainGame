using UnityEngine;
using System.Collections;

public class destroyCrate : MonoBehaviour {

	private Transform myTransform;
	// Use this for initialization
	void Start () {
		myTransform = transform;
	}
	// Update is called once per frame
	void Update () {
		if(myTransform.tag == "obstacle"){
			if(myTransform.position.y < -5.4){
				Destroy(myTransform.gameObject);
			}
		}
		if(myTransform.tag == "food"){
			if(myTransform.position.y < -5){
				GM.highScore();
				GM.ResetSpeed();
				GM.loadPage();
			}
		}
	}
}
