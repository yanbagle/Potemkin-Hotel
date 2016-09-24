#pragma strict

public var hasPaint = false;

var greenPaint: Green;
var bluePaint: Blue;
var artist: Artist1;

function Start () {
	var g = GameObject.Find("paint bucket - green");
	var b = GameObject.Find("paint bucket - blue");
	var a = GameObject.Find("human_normal_artist2");
	
	artist = a.GetComponent("Artist1");
	greenPaint = g.GetComponent("Green");
	bluePaint = b.GetComponent("Blue");
}

function Update () {

}

function OnMouseDown(){
	if(artist.talkedTo){
		artist.donePainting = false;
		hasPaint = true;
		greenPaint.hasPaint = false;
		bluePaint.hasPaint = false; 
	}
}