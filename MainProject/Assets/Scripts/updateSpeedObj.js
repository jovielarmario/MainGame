#pragma strict

var obj : GameObject;
private var speed : float;
var cratePos : int = 0;

function Start () {
	if(obj.tag == "turtle"){
		speed = rigidbody2D.velocity.y;
		Debug.Log("turtle speed : "+speed);
	}else{
		speed = rigidbody2D.velocity.y;
		Debug.Log("monkey speed : "+speed);
	}
}
