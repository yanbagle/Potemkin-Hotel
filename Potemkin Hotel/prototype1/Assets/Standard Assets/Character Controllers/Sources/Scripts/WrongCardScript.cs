using UnityEngine;
using System.Collections;

public class WrongCardScript : MonoBehaviour {
	
	public int showTime = 0;
	public bool hasCard = false;
	public bool playedNarration = false;
	
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(hasCard){
			showTime++;
		
		}
	}
	
	void OnMouseDown(){
		hasCard = true;
		if(playedNarration == false){
			playSound();
		}
		playedNarration = true;
	}
	
	public void playSound(){
		audio.Play ();
	}
	
	void OnGUI() {
		//GUI.DrawTexture (Rect(Event.current.mousePosition.x-cursorSizeX/2, Event.current.mousePosition.y-cursorSizeY/2, cursorSizeX, cursorSizeY), yourCursor);
	}
}
