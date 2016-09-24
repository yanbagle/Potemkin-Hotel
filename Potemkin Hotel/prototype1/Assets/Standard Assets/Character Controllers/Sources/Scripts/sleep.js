#pragma strict

var topEyelid : GameObject;
var bottomEyelid : GameObject;
var hasSlept : boolean;
var inside : boolean = false;

function Start () {
	topEyelid = GameObject.Find("upperEyelid");
	bottomEyelid = GameObject.Find("lowerEyelid");
	hasSlept = false;
}

function Update () {
	if (inside) {
		if (Input.GetMouseButtonDown(0) && !hasSlept) {
			bottomEyelid.animation.Play("closeBottomEyelid");
			topEyelid.animation.Play("closeTopEyelid");
			hasSlept = true;
		}
	}
}

function OnTriggerEnter(Col : Collider){
  	if(Col.gameObject.tag == "Bed"){
  		inside = true;
  	
  	}
  
  }
  
function OnTriggerExit(Col : Collider){
  	if(Col.gameObject.tag == "Bed"){
  		inside = false;
  	}
  
  }