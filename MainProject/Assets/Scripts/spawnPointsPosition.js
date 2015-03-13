#pragma strict

//this is the function for setting the wall colliders in the screen

var wallLeft : Transform;
var wallRight : Transform;
var rightPoint : int;
var monkeyOrTurtle : float;
function Start () {
	if(monkeyOrTurtle == 0){
		if(rightPoint == 0)
			transform.position.x = ( ( wallRight.position.x - wallLeft.position.x ) - 0.5f ) /2 ;
		else
			transform.position.x = ( wallRight.position.x - wallLeft.position.x ) ;
	}else{
		if(rightPoint == 0)
			transform.position.x = -1*( ( ( wallRight.position.x - wallLeft.position.x ) - 0.5f ) /2 );
		else
			transform.position.x = -1*(wallRight.position.x - wallLeft.position.x );
	}
}
