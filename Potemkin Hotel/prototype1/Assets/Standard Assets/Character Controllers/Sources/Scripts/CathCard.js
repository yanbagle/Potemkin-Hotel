#pragma strict

public var hasCard = false;

var hasAlien: AlienCard;
var hasInvalid: InvalidCard;
var hasInvalid1: InvalidCard;
var hasPlayer: PlayerCard;

function Start () {
	var a = GameObject.Find("alien card");
	hasAlien = a.GetComponent("AlienCard"); 
	
	var i = GameObject.Find("invalid card");
	hasInvalid = i.GetComponent("InvalidCard"); 
	
	var i1 = GameObject.Find("invalid card 1");
	hasInvalid1 = i1.GetComponent("InvalidCard"); 
	
	var p = GameObject.Find("player card");
	hasPlayer = p.GetComponent("PlayerCard"); 
}

function Update () {
	
}

function OnMouseDown(){
	hasCard = true;
	hasAlien.hasCard = false;
	hasInvalid.hasCard = false;
	hasInvalid1.hasCard = false;
	hasPlayer.hasCard = false;
}

