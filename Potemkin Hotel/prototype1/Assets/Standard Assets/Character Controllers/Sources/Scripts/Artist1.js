#pragma strict

public var talkedTo = false;

var audio1: AudioSource;
var audio2: AudioSource;

public var donePainting = false;

public var paintScript: PaintJS;

public var yPos: float;
public var headYPos: float;
public var jumpTimer: int;


function Start () {
	var audioSources = GetComponents(AudioSource); 
	audio1 = audioSources[0];
	audio2 = audioSources[1];
	
	paintScript = GameObject.Find("Main Camera").GetComponent("PaintJS");
	
	yPos = rigidbody.position.y;
	
	for (var child : Transform in transform) {
		if(child.name == "pCylinder1"){
			//child.position = new Vector3();
			headYPos = child.position.y;
		}
 		   
	}

}

function Update () {
	jumpTimer++;
	
	if(talkedTo == false && jumpTimer % 4 == 0){
		jumpingUp();
	
	}
	
	if(talkedTo == false && jumpTimer % 8 == 0){
		jumpingDown();
		
	}
	
	if(audio.isPlaying == false && talkedTo){
		moveHeadDown();
	}
	
	if(talkedTo && (audio1.isPlaying || audio2.isPlaying)){
		if(jumpTimer % 6 == 0){
			moveHeadUp();
		
		}
		if (jumpTimer % 12 == 0){
			moveHeadDown();
		
		}
		
	
	}
	
	//Debug.Log(paintScript.paintingTime);
	if(paintScript.paintingTime >= 300 && donePainting == false){
		talkedTo = false;
	
	}
	
	
}

function OnMouseDown(){
	if(talkedTo == false && paintScript.paintingTime == 0){
		talkedTo = true;
		audio1.Play();
		jumpingDown();
	}
	else{
		if(paintScript.isPainting){
			audio2.Play();
			donePainting = true;
			talkedTo = true;
		}

	}
	
}

function jumpingUp(){
	
	rigidbody.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationZ;
	rigidbody.position = new Vector3(rigidbody.position.x,yPos + 0.5, rigidbody.position.z);
	
}

function jumpingDown(){
	
	rigidbody.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationZ;
	rigidbody.position = new Vector3(rigidbody.position.x,yPos, rigidbody.position.z);
	
}

function moveHeadUp(){
	for (var child : Transform in transform) {
		if(child.name == "pCylinder1"){
			child.position = new Vector3(child.position.x, headYPos + 0.1, child.position.z);
		}
	}

}

function moveHeadDown(){
	
	for (var child : Transform in transform) {
		if(child.name == "pCylinder1"){
			child.position = new Vector3(child.position.x, headYPos , child.position.z);
			
		}
	}
}











