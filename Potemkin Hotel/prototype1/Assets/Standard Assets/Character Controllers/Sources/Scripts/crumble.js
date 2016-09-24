#pragma strict

public var startFalling : boolean;
var time : int;
var fallDuration : int;
var wave1FallSpeed : float;
var wave2FallSpeed : float;
var wave3FallSpeed : float;
var wave4FallSpeed : float;
var wave5FallSpeed : float;
var one : boolean;
var two : boolean;
var three : boolean;
var four : boolean;
var five : boolean;
var soundPlayed : boolean;
var sound : AudioClip;

public var closingNar: boolean;
var closingNarration: AudioClip;

function Start () {
	startFalling = false;
	time = 0;
	fallDuration = 681;
	wave1FallSpeed = 0.1;
	wave2FallSpeed = 0.1;
	wave3FallSpeed = 0.1;
	wave4FallSpeed = 0.1;
	wave5FallSpeed = 0.1;
	one = false;
	two = false;
	three = false;
	four = false;
	five = false;
	soundPlayed = false;
	closingNar = false;
}

function Update () {
	
	if (startFalling && time<fallDuration) {

		if (!soundPlayed) {
			audio.Play();
			soundPlayed = true;
			Debug.Log("sound played");
		}
	
		time++;
		if (time>=0) {
			// drop the floor/ ceiling
			for (var obj : GameObject in GameObject.FindGameObjectsWithTag("wave1")) {
				obj.transform.position.y -= wave1FallSpeed;
				obj.collider.enabled = false;
			}
			
			if (!one) {
				for (var obj : GameObject in GameObject.FindGameObjectsWithTag("walls1")) {
					//obj.rigidbody.constraints = ~RigidbodyConstraints.FreezeAll;
					obj.AddComponent(Rigidbody);
				}
				one = true;
				
				for (var obj : GameObject in GameObject.FindGameObjectsWithTag("delete")) {
					Destroy(obj);
				}
				for (var obj : GameObject in GameObject.FindGameObjectsWithTag("Ladder")) {
					Destroy(obj);
				}
				
			}
			wave1FallSpeed += 0.01;
		}
		if (time>=50) {
			// drop the floor/ ceiling
			for (var obj : GameObject in GameObject.FindGameObjectsWithTag("wave2")) {
				obj.transform.position.y -= wave2FallSpeed;
				obj.collider.enabled = false;
			}
			
			if (!two) {
				for (var obj : GameObject in GameObject.FindGameObjectsWithTag("walls2")) {
					//obj.rigidbody.constraints = ~RigidbodyConstraints.FreezeAll;
					obj.AddComponent(Rigidbody);
				}
				two = true;
			}
			wave2FallSpeed += 0.01;
		}
		if (time>=100) {
			// drop the floor/ ceiling
			for (var obj : GameObject in GameObject.FindGameObjectsWithTag("wave3")) {
				obj.transform.position.y -= wave3FallSpeed;
				obj.collider.enabled = false;
			}
			
			if (!three) {
				for (var obj : GameObject in GameObject.FindGameObjectsWithTag("walls3")) {
					//obj.rigidbody.constraints = ~RigidbodyConstraints.FreezeAll;
					obj.AddComponent(Rigidbody);
				}
				three = true;
			}
			wave3FallSpeed += 0.01;
		}
		if (time>=150) {
		
			// drop the floor/ ceiling
			for (var obj : GameObject in GameObject.FindGameObjectsWithTag("wave4")) {
				obj.transform.position.y -= wave4FallSpeed;
				obj.collider.enabled = false;
			}
			
			if (!four) {
				for (var obj : GameObject in GameObject.FindGameObjectsWithTag("walls4")) {
					//obj.rigidbody.constraints = ~RigidbodyConstraints.FreezeAll;
					obj.AddComponent(Rigidbody);
					//obj.transform.position.y += 30;
					//Destroy(obj);
				}
				four = true;
			}
			wave4FallSpeed += 0.01;
		}
		if (time>=200) {
			// drop the floor/ ceiling
			for (var obj : GameObject in GameObject.FindGameObjectsWithTag("wave5")) {
				obj.transform.position.y -= wave5FallSpeed;
				obj.collider.enabled = false;
			}
			
			if (!five) {
				for (var obj : GameObject in GameObject.FindGameObjectsWithTag("walls5")) {
					//obj.rigidbody.constraints = ~RigidbodyConstraints.FreezeAll;
					obj.AddComponent(Rigidbody);
					obj.rigidbody.useGravity = true;
				}
				five = true;
			}
			wave5FallSpeed += 0.01;
		}
		
	
	}
	
	else if(time >= fallDuration){
		time++;
		if(time > fallDuration + 160 && !closingNar){
				audio.PlayOneShot(closingNarration);
				closingNar = true;
		}
	
	}
	
	
	
}