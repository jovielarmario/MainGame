using UnityEngine;
using System.Collections;

public class switchLanes : MonoBehaviour {

	public float speedMonkey = 20;
	public float speedTurtle = 10;
	public GameObject turtle;
	public GameObject monkey;
	public GameObject trackOfMonkey;
	public GameObject trackOfTurtle;
	public GameObject grass1, grass2, grass3, grass4;


	// Use this for initialization
	void Start () {
		trackOfMonkey.rigidbody2D.AddForce (Vector2.up*-(speedMonkey-16));
		grass1.rigidbody2D.AddForce (Vector2.up*-(speedMonkey-16));
		grass2.rigidbody2D.AddForce (Vector2.up*-(speedMonkey-16));
		trackOfTurtle.rigidbody2D.AddForce (Vector2.up*-(speedTurtle-2));
		grass3.rigidbody2D.AddForce (Vector2.up*-(speedTurtle-2));
		grass4.rigidbody2D.AddForce (Vector2.up*-(speedTurtle-2));
	}
	
	// Update is called once per frame
	void Update () { 
		if(Input.GetMouseButtonDown(0) ){
			if(Input.mousePosition.x < Screen.width / 2){
				if(monkey.transform.position.x < -2){
					Debug.Log("push monkey to right");
					monkey.rigidbody2D.AddForce (Vector2.right*speedMonkey);
				}else{
					Debug.Log("push monkey to left");
					monkey.rigidbody2D.AddForce (Vector2.right*-speedMonkey);
				}
			}
			
			//for the switching lanes of turtle
			else{
				if(turtle.transform.position.x < 2){
					Debug.Log("push turtle to right");
					turtle.rigidbody2D.AddForce (Vector2.right*speedTurtle);
				}else
				{
					Debug.Log("push turtle to left");
					turtle.rigidbody2D.AddForce (Vector2.right*-speedTurtle);
				}
			}
		}
	}
}
