#pragma strict

var played = false;

function Start () {

}

function Update () {

}

function OnTriggerEnter(other : Collider){
	if(played == false){
		audio.Play();
		played = true;
		Debug.Log("playing");
	}
	

}