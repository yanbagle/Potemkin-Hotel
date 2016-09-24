#pragma strict

var yourCursor : Texture2D;  // Your cursor texture
var cursorSizeX : int = 16;  // Your cursor size x
var cursorSizeY : int = 16;  // Your cursor size y

public var playerSleep: sleepOkay;

function Start () {
	Screen.showCursor = false;
	
	var obj = gameObject.Find("SleepTriggerCube");
	playerSleep = obj.GetComponent("sleepOkay");
}

function Update () {

}

function OnGUI()
{
	if(!playerSleep.eyesClosed){
		
		   GUI.DrawTexture (Rect(Event.current.mousePosition.x-cursorSizeX/2, Event.current.mousePosition.y-cursorSizeY/2, cursorSizeX, cursorSizeY), yourCursor);

	}
}