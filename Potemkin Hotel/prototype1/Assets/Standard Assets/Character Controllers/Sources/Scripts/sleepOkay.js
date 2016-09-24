#pragma strict

var ending : Texture2D;  // Your cursor texture
var showEnding: boolean;

var topEyelid : GameObject;
var bottomEyelid : GameObject;
public var hasSlept : boolean;
public var awake : boolean;
var time : int;
var camScript : shakeCamera;
var fallScript : crumble;

var rumblePlayed : boolean;
var rumbleSound : AudioClip;
var snoring : AudioClip;
var whatTheHeck: AudioClip;



var gameDone : boolean; // controls the final eye close

public var doneCollapsing : boolean;

public var eyesClosed: boolean;


function Start () {
	topEyelid = GameObject.Find("upperEyelid");
	bottomEyelid = GameObject.Find("lowerEyelid");
	hasSlept = false;
	awake = false;
	time = 0;
	camScript = GameObject.Find("Main Camera").GetComponent("shakeCamera");
	fallScript = GameObject.Find("First Person Controller").GetComponent("crumble");
	gameDone = false;
	doneCollapsing = false;
	rumblePlayed = false;
	showEnding = false;
	
}

function Update () {
	// turns off shaking
	if (time > 920) {
		camScript.shaking = false;
		audio.Stop();
	}
	
	
	
	// turns on shaking
	if (hasSlept) { //&& time < 1000) {
		time++;
		if (time > 500 && !rumblePlayed) {
			audio.Stop();
			audio.PlayOneShot(rumbleSound);
			rumblePlayed = true;
			eyesClosed = true;
		}
		
		if (time > 640 && !awake && time < 660) {
			audio.PlayOneShot(whatTheHeck);
			bottomEyelid.animation.Play("openBottomEyelid");
			topEyelid.animation.Play("openTopEyelid");
			awake = true;
			camScript.shaking = true;
		}
		// begins the hotel collapse
		if (time > 800) {
			fallScript.startFalling = true;
			doneCollapsing = true;
		}
		
		// check for ending
	if (time > 3100 && !gameDone) {
		bottomEyelid.animation.Play("closeBottomEyelid");
		topEyelid.animation.Play("closeTopEyelid");
		gameDone = true;
	}
	if(time > 3300){
		showEnding = true;
	
	}
	
	
	
	}
	
	

}

function OnMouseDown(){
	if(!hasSlept) {
		bottomEyelid.animation.Play("closeBottomEyelid");
		topEyelid.animation.Play("closeTopEyelid");
		hasSlept = true;
		audio.clip = snoring;
		audio.loop = true;
		audio.Play();
	}
}

function OnGUI(){
	if(showEnding){
		GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), ending, ScaleMode.ScaleToFit, true, 0);
		Debug.Log("ending");
	}

}





