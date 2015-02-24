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
		if(myTransform.position.y < -5.4){
			Destroy(myTransform.gameObject);
		}
	}
}
