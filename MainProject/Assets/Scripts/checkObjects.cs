using UnityEngine;
using System.Collections;

public class checkObjects : MonoBehaviour {

	/*
	this is the class of functions when the character(turtle/rabbit) hit the 
	crate or the food.
	 */

	void OnCollisionEnter2D (Collision2D colInfo){
		if (colInfo.collider.tag == "food") {		//checks if is a food
			Destroy(colInfo.gameObject);			//the character eats the food
			GM.AddScore("food");					//add 1 to score

		}
		if (colInfo.collider.tag == "obstacle"){	//checks if it is an obstacle
			if(GM.score > GM.high){					//compare the high score

				GM.highScore();
			}
			GM.loadPage();							//fade to loadscreen and reset the games
		}
	}
}