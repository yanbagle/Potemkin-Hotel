#pragma strict

var player: sleepOkay;

function Start () {
	player = gameObject.Find("SleepTriggerCube").GetComponent("sleepOkay");
}

function Update () {
	if(player.gameDone){
		if(audio.volume < 0.6){
	
				audio.volume += 0.005 * Time.deltaTime;
			
		}
		
	}	

	
}