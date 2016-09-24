#pragma strict

var player: PaintJS;

function Start () {
	var paintObj = GameObject.Find("Main Camera");
	player = paintObj.GetComponent("PaintJS");
}

function Update () {
	
}

function OnMouseDown(){
	
		audio.Play();
	
	

}