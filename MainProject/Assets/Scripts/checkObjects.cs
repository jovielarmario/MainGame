using UnityEngine;
using System.Collections;

public class checkObjects : MonoBehaviour {

	void OnCollisionEnter2D (Collision2D colInfo){
		if (colInfo.collider.tag == "food") {
			Destroy(colInfo.gameObject);
			GM.AddScore("food");

		}
		if (colInfo.collider.tag == "obstacle"){
			if(GM.score > GM.high){
				GM.highScore();
			}
			GM.loadPage();
			//fade to loadscreen
		}
	}
}