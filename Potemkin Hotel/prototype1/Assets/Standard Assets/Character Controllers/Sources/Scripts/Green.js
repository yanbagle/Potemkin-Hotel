#pragma strict

public var hasPaint = false;

var redPaint: Red;
var bluePaint: Blue;
var artist: Artist1;

function Start () {
	var r = GameObject.Find("paint bucket - red");
	var b = GameObject.Find("paint bucket - blue");
	var a = GameObject.Find("human_normal_artist2");
	
	artist = a.GetComponent("Artist1");
	redPaint = r.GetComponent("Red");
	bluePaint = b.GetComponent("Blue");
}

function Update () {

}

function OnMouseDown(){
	if(artist.talkedTo){
		artist.donePainting = false;
		hasPaint = true;
		redPaint.hasPaint = false;
		bluePaint.hasPaint = false; 
	}
}