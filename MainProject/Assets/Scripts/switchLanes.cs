using UnityEngine;
using System.Collections;

public class switchLanes : MonoBehaviour {

	public GameObject turtle;
	public GameObject monkey;
	public GameObject trackOfMonkey;
	public GameObject trackOfTurtle;
	public GameObject grass1, grass2, grass3, grass4;


	// Use this for initialization
	void Start () {
		trackOfMonkey.rigidbody2D.AddForce (Vector2.up*-(GM.speedT));
		grass1.rigidbody2D.AddForce (Vector2.up*-(GM.speedT));
		grass2.rigidbody2D.AddForce (Vector2.up*-(GM.speedT));
		trackOfTurtle.rigidbody2D.AddForce (Vector2.up*-(GM.speedT));
		grass3.rigidbody2D.AddForce (Vector2.up*-(GM.speedT));
		grass4.rigidbody2D.AddForce (Vector2.up*-(GM.speedT));
	}
	
	// Update is called once per frame
	void Update () {

		//for the trial input of mouse
#if UNITY_EDITOR
		if(Input.GetMouseButtonDown(0) ){
			if(Input.mousePosition.x < Screen.width / 2f){
				if(monkey.transform.position.x < -2f){
					monkey.rigidbody2D.AddForce (Vector2.right*(GM.speedR+10f));
				}else{
					monkey.rigidbody2D.AddForce (Vector2.right*-(GM.speedR+10f));
				}
			}
			
			//for the switching lanes of turtle
			else{
				if(turtle.transform.position.x < 2f){
					turtle.rigidbody2D.AddForce (Vector2.right*(GM.speedT+10f));
				}else
				{
					turtle.rigidbody2D.AddForce (Vector2.right*-(GM.speedT+10f));
				}
			}
		}
#endif

		//for the touch input
		if(Input.touchCount > 0 ){
			foreach(Touch touch in Input.touches){
				if(touch.phase == TouchPhase.Began){
					if(touch.position.x < Screen.width / 2f){
						if(monkey.transform.position.x < -2f){
							monkey.rigidbody2D.AddForce (Vector2.right*(GM.speedR+10f));
						}else{
							monkey.rigidbody2D.AddForce (Vector2.right*-(GM.speedR+10f));
						}
					}
					
					//for the switching lanes of turtle
					else{
						if(turtle.transform.position.x < 2f){
							turtle.rigidbody2D.AddForce (Vector2.right*(GM.speedT+10f));
						}else
						{
							turtle.rigidbody2D.AddForce (Vector2.right*-(GM.speedT+10f));
						}
					}
				}
			}
		}
	}

}
