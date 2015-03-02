#pragma strict
//for grass
var position : float;
var inSet : float;
private var cam : Camera;

function Awake () {
	cam = Camera.main;
}


function Start () {
	
	transform.position.x = position * ((cam.orthographicSize * Screen.width / Screen.height) + inSet);

}
