#pragma strict


private var old : float;
var speed : float;
function Start () {
	old = transform.position.y;
}

function Update () {
	transform.position.y = old;
}
