#pragma strict

var sound: AudioClip;
var player: sleepOkay;

function Start(){
		player = gameObject.Find("SleepTriggerCube").GetComponent("sleepOkay");


}

function OnMouseDown(){
	if(!player.hasSlept){
		audio.Play();
	}
	

}