#pragma strict
var alienCard : Texture;
var playerCard : Texture;
var cathCard : Texture;
var invalidCard : Texture;
var blackScreen: Texture;

public var playerCardScanned = false;

var laptopScreen : GameObject;

var alienCardScript: AlienCard;
var invalidCardScript1: InvalidCard;
var invalidCardScript2: InvalidCard;
var playerCardScript: PlayerCard;
var cathCardScript: CathCard;

var beep: AudioSource; 
var rightCard: AudioSource;
var alienCardAudio: AudioSource;
var cathAudio: AudioSource;
var invalidAudio: AudioSource;

function Start () {

	laptopScreen.renderer.material.mainTexture = blackScreen;
	
	var aSources = GetComponents(AudioSource);
    beep = aSources[0];
    rightCard = aSources[1];
    alienCardAudio = aSources[2];
    cathAudio = aSources[3];
    invalidAudio = aSources[4];
	
	var a = GameObject.Find("alien card");
	alienCardScript = a.GetComponent("AlienCard"); 
	
	var i1 = GameObject.Find("invalid card 1");
	invalidCardScript1 = i1.GetComponent("InvalidCard"); 
	
	var i2 = GameObject.Find("invalid card");
	invalidCardScript2 = i2.GetComponent("InvalidCard"); 
	
	var c = GameObject.Find("cath card"); 
	cathCardScript = c.GetComponent("CathCard"); 
	
	var p = GameObject.Find("player card");
	playerCardScript = p.GetComponent("PlayerCard"); 
}

function Update () {
	
}

function OnTriggerEnter(Target: Collider){

	beep.Play();
	
	if(alienCardScript.hasCard){
		laptopScreen.renderer.material.mainTexture = alienCard;
		alienCardAudio.Play();
	}
	else if(invalidCardScript1.hasCard || invalidCardScript2.hasCard){
		laptopScreen.renderer.material.mainTexture = invalidCard;
		invalidAudio.Play();
	}
	
	else if(cathCardScript.hasCard){
		laptopScreen.renderer.material.mainTexture = cathCard;
		cathAudio.Play();
	}
	
	else if(playerCardScript.hasCard){
		laptopScreen.renderer.material.mainTexture = playerCard;
		playerCardScanned = true;
		rightCard.Play();
	}

	
}

function OnTriggerExit(Target: Collider){
	laptopScreen.renderer.material.mainTexture = blackScreen;

}