#pragma strict

var smooth = 2.0;
var DoorOpenAngle = 90.0;
private var current: int;
private var open : int;
private var close : int;

private var defaultRot : Vector3;
private var openRot : Vector3;

private var playedSound = false;

function Start(){
	defaultRot = transform.eulerAngles;
	openRot = new Vector3 (defaultRot.x,  (defaultRot.y + DoorOpenAngle) , defaultRot.z);
	current = -1;
	open = 0;
	close = 1;
}

//Main function
function Update (){
	if(current == open&& (transform.eulerAngles.y<defaultRot.y+87.0)){
		//Open door
		transform.eulerAngles = Vector3.Slerp(transform.eulerAngles, openRot, Time.deltaTime * smooth);
		playSound();
	}
	else if(current == close){
		//Close door
		transform.eulerAngles = Vector3.Slerp(transform.eulerAngles, defaultRot, Time.deltaTime * smooth);
		playSound();
	}
	
	/*
	if(Input.GetMouseButtonDown(0)){//right now clicking anywhere opens the door
		
	}
	*/
	
}

function playSound(){
		if(playedSound == false){
			audio.Play ();
		}
		playedSound = true;
}

function OnMouseDown(){
	playedSound = false;
	if(current == open){
		current = close;
	}
	else{
		current = open;
	}
}
