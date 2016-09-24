#pragma strict

public var hasCard = false;

var hasAlien: AlienCard;
var hasPlayer: PlayerCard;
var hasCath: CathCard;

function Start () {
	var a = GameObject.Find("alien card");
	hasAlien = a.GetComponent("AlienCard"); 
	
		
	var p = GameObject.Find("player card");
	hasPlayer = p.GetComponent("PlayerCard"); 
	
	var c = GameObject.Find("cath card");
	hasCath =c.GetComponent("CathCard"); 
}

function Update () {

}

function OnMouseDown(){
	hasCard = true;
	hasAlien.hasCard = false;
	hasPlayer.hasCard = false;
	hasCath.hasCard = false;
}

