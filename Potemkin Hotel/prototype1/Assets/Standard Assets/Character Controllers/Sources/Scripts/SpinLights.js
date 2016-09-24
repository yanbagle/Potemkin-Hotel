#pragma strict

var spinX : int  = 0;
var spinY : int  = 0;
var spinZ : int  = 0;

function Start () {

}

function Update () {
	transform.Rotate(spinX, spinY, spinZ);
	
	
}

function OnMouseOver(){
	if(Input.GetMouseButtonDown(0)){
		spinY++;
	
	}
	else if(Input.GetMouseButtonDown(1)){
		spinY--;
	
	}

}
