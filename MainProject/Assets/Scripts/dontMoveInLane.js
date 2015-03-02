#pragma strict

private var cam : Camera;
private var oldY : float;
private var oldX : float;
private var speed : float;
var inSetX : float;
var monkeyOrTurtle : float;

function Awake () {
	cam = Camera.main;
}

function Start () {
	oldY = transform.position.y = -4.5;
	oldX = transform.position.x = monkeyOrTurtle*((cam.orthographicSize * Screen.width / Screen.height) + inSetX);
}

function Update () {
	transform.position.y = oldY;
	if(transform.position.x > oldX || transform.position.x < oldX){
		speed = rigidbody2D.velocity.x;
	}
}

function OnCollisionEnter2D (colInfo : Collision2D) {
	if(colInfo.collider.tag == "food"){
		rigidbody2D.velocity.x = speed;
	}
}

