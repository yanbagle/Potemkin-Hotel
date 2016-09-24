#pragma strict

public var hasPaint = false;

var greenPaint: Green;
var redPaint: Red;
var artist: Artist1;

function Start () {
	var g = GameObject.Find("paint bucket - green");
	var r = GameObject.Find("paint bucket - red");
	var a = GameObject.Find("human_normal_artist2");
	
	artist = a.GetComponent("Artist1");
	greenPaint = g.GetComponent("Green");
	redPaint = r.GetComponent("Red");
}

function Update () {

}

function OnMouseDown(){
	if(artist.talkedTo){
		artist.donePainting = false;
		hasPaint = true;
		greenPaint.hasPaint = false;
		redPaint.hasPaint = false; 
	
	}

}