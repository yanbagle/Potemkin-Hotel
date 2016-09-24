#pragma strict

var topEyelid : GameObject;
var bottomEyelid : GameObject;

function Start () {
	topEyelid = GameObject.Find("upperEyelid");
	bottomEyelid = GameObject.Find("lowerEyelid");
}

function Update () {
	
	

	//if (Input.GetMouseButtonDown(0)) {
	//	bottomEyelid.animation.Play("closeBottomEyelid");
	//	topEyelid.animation.Play("closeTopEyelid");
	//}
	//if (Input.GetMouseButtonUp(1)) {
	//	bottomEyelid.animation.Play("openBottomEyelid");
	//	topEyelid.animation.Play("openTopEyelid");
	//}
}