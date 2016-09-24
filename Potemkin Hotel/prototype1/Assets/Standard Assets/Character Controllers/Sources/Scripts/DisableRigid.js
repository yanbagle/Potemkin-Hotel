#pragma strict

var player: sleepOkay;

function Start () {
	player = gameObject.Find("SleepTriggerCube").GetComponent("sleepOkay");
}

function Update () {
	if(player.hasSlept){
		var hinges :Transform[] = FindObjectsOfType(Transform) as Transform[];
	
		for(var i = 0; i < hinges.Length; i++){
			if(hinges[i].rigidbody != null){
				hinges[i].rigidbody.detectCollisions = false;

			}
		
		}
	
	}
	
}