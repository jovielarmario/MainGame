#pragma strict
//for grass
var position : float;
var inSet : float;
private var cam : Camera;

//sets characters in the starting position

function Awake () {
	cam = Camera.main;
}


function Start () {
	
	transform.position.x = position * ((cam.orthographicSize * Screen.width / Screen.height) + inSet);

}
