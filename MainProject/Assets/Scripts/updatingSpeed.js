#pragma strict
import System.Collections.Generic;

//this performs the speed change in every moving object in the game
var speed : float;

private var old : float;


function Start () {
	if(transform.position.x > 0){
		old = speed = GameObject.FindGameObjectWithTag("GM").GetComponent(GM).speedTurtle;
	}else{
		old = speed = GameObject.FindGameObjectWithTag("GM").GetComponent(GM).speedRabbit;
	}
	rigidbody2D.velocity.y = -speed;
}


function Update () {

	
	if(transform.position.x > 0 || transform.position.z < 0){
		speed = GameObject.FindGameObjectWithTag("GM").GetComponent(GM).speedTurtle;
		if(speed > old){
			rigidbody2D.velocity.y = -speed;
			old = speed;
		}
	}
	if(transform.position.x < 0 || transform.position.z > 0){
		speed = GameObject.FindGameObjectWithTag("GM").GetComponent(GM).speedRabbit;
		if(speed > old){
			rigidbody2D.velocity.y = -speed;
			old = speed;
		}
	}
	
}