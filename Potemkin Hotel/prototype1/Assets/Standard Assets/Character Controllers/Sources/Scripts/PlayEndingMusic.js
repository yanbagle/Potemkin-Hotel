#pragma strict

var player: sleepOkay;
var soundPlayed: boolean;
var timer: int = 0;

function Start () {
	player = gameObject.Find("SleepTriggerCube").GetComponent("sleepOkay");
	soundPlayed = false;
}

function Update () {
	if(player.gameDone && !soundPlayed){
		timer++;
		if(timer > 30){
			audio.Play();
			soundPlayed = true;
			
		}
		
	}
}