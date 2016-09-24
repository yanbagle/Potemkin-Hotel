using UnityEngine;
using System.Collections;

public class IntroListener : MonoBehaviour {
	
	public bool playedNarration = false;
	
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnTriggerEnter(Collider other) {
		playSound();
		playedNarration = true;
	}
	
	void playSound(){
		if(playedNarration == false){
			audio.Play();
			Debug.Log("intro");
		}
		
	
	}
}
