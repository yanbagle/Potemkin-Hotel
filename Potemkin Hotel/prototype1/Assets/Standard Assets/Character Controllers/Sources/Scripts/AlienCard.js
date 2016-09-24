#pragma strict

public var hasCard = false;

var hasInvalid: InvalidCard;
var hasInvalid1: InvalidCard;
var hasPlayer: PlayerCard;
var hasCath: CathCard;

function Start () {
	var i = GameObject.Find("invalid card");
	hasInvalid = i.GetComponent("InvalidCard"); 
	
	var i1 = GameObject.Find("invalid card 1");
	hasInvalid1 = i1.GetComponent("InvalidCard"); 
	
	var p = GameObject.Find("player card");
	hasPlayer = p.GetComponent("PlayerCard"); 
	
	var c = GameObject.Find("cath card");
	hasCath = c.GetComponent("CathCard"); 
	
}

function Update () {
	
}

function OnMouseDown(){
	hasCard = true;
	hasInvalid.hasCard = false;
	hasInvalid1.hasCard = false;
	hasPlayer.hasCard = false;
	hasCath.hasCard = false;
}