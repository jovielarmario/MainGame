using UnityEngine;
using System.Collections;

public class checkObjects : MonoBehaviour {

	void OnCollisionEnter2D (Collision2D colInfo){
		if (colInfo.collider.tag == "food") {
			if(transform.tag == "turtle"){
				GM.AddSpeed("turtle");
			}else{
				GM.AddSpeed("rabbit");
			}
			Destroy(colInfo.gameObject);
			GM.AddScore("food");

		}
		if (colInfo.collider.tag == "obstacle"){
			if(GM.score > GM.high){
				GM.highScore();
			}
			GM.ResetSpeed();
			GM.loadPage();
			//fade to loadscreen
		}
	}
}