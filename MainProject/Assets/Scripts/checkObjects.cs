using UnityEngine;
using System.Collections;

public class checkObjects : MonoBehaviour {
	private Vector2 old;
	// Use this for initialization

	void Update (){

	}

	void OnCollisionEnter2D (Collision2D colInfo){
		if (colInfo.collider.tag == "food") {
			Destroy(colInfo.gameObject);
			Debug.Log(rigidbody2D.velocity.y);
			GM.AddScore("food");
		}
		if (colInfo.collider.tag == "obstacle"){
			Debug.Log("Reset");
			Application.LoadLevel(0);
		}
	}
}