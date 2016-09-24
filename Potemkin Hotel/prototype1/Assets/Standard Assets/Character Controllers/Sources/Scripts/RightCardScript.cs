using UnityEngine;
using System.Collections;

public class RightCardScript : MonoBehaviour {
	
	public bool hasRoomCard = false;
	public int showTime = 0;
	public bool playedNarration = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(hasRoomCard){
			showTime++;
		}
		
	}
	
	void OnMouseDown(){
		hasRoomCard = true;
		if(playedNarration == false){
			playSound();
		}
		playedNarration = true;
		
	}
	
	public void playSound(){
		audio.Play ();
	}
	
	
	
}
