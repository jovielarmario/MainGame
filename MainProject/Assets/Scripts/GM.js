#pragma strict

var speedTurtle : float = 0;
var speedRabbit : float = 0;
var speedToAdd : float = 0;

function AddSpeed(play : int) {
	if(play == 1){
		speedTurtle += speedToAdd;
	}else
		speedRabbit += speedToAdd;
}

