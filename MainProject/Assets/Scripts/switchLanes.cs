using UnityEngine;
using System.Collections;

public class switchLanes : MonoBehaviour {

	public GameObject turtle;
	public GameObject monkey;

	void Update () {

		//for the trial input of mouse
#if UNITY_EDITOR
		if(Input.GetMouseButtonDown(0) ){
			if(Input.mousePosition.x < Screen.width / 2f){
				if(monkey.transform.position.x < -2f){
					monkey.rigidbody2D.AddForce (Vector2.right*(GM.speedR+20f));
				}else{
					monkey.rigidbody2D.AddForce (Vector2.right*-(GM.speedR+20f));
				}
			}
			
			//for the switching lanes of turtle
			else{
				if(turtle.transform.position.x < 2f){
					turtle.rigidbody2D.AddForce (Vector2.right*(GM.speedT+20f));
				}else
				{
					turtle.rigidbody2D.AddForce (Vector2.right*-(GM.speedT+20f));
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
							monkey.rigidbody2D.AddForce (Vector2.right*(GM.speedR+20f));
						}else{
							monkey.rigidbody2D.AddForce (Vector2.right*-(GM.speedR+20f));
						}
					}
					
					//for the switching lanes of turtle
					else{
						if(turtle.transform.position.x < 2f){
							turtle.rigidbody2D.AddForce (Vector2.right*(GM.speedT+20f));
						}else
						{
							turtle.rigidbody2D.AddForce (Vector2.right*-(GM.speedT+20f));
						}
					}
				}
			}
		}
	}

}
