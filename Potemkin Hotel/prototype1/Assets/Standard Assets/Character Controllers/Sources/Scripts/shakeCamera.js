#pragma strict

var hold : Vector3;
var f : int;
public var shaking : boolean;

function Start () {
	f = 0;
	shaking = false;
}

function Update () {
	//shaking = GameObject.Find("SleepTriggerCube").GetComponent("sleepOkay")
	if (shaking==true) {
		GameObject.Find("Graphics").renderer.enabled = false;
		if (f == 0) {
			hold = this.transform.position;
		}
		else if (f>0) {
			var randNrX = Random.Range(0.5,-0.5);
			var randNrY = Random.Range(0.5,-0.5);
			var randNrZ = Random.Range(0.5,-0.5);
			this.transform.position += Vector3(randNrX,randNrY,randNrZ);
		}
		
		f++;
		if (f >3 ) {
			this.transform.position = GameObject.FindGameObjectWithTag("Player").transform.position + Vector3(0,0.9,0);
			f = 0;
		}
	}
	else {
		GameObject.Find("Graphics").renderer.enabled = true;
		this.transform.position = GameObject.FindGameObjectWithTag("Player").transform.position + Vector3(0,0.9,0);
	}
}

public function startShake () {
	shaking = true;
}