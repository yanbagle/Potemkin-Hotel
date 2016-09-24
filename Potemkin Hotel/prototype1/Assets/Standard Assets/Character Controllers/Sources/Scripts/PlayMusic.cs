using UnityEngine;
using System.Collections;

public class PlayMusic : MonoBehaviour {

	public SecretRoomSounds playMusic;
	public MusicStop music;

	public bool played = false;

	// Use this for initialization
	void Start () {
		GameObject enterObj = GameObject.Find ("SecretRoomTriggerEnterance");
		playMusic = enterObj.GetComponent<SecretRoomSounds>();

		music = GameObject.Find("MusicStopTrigger").GetComponent<MusicStop>();
	}
	
	// Update is called once per frame
	void Update () {
		if(playMusic.playerEntered && played == false){
			audio.Play();		
			played = true;
		}

		if(music.stopMusic){
			audio.Stop ();		

		}
	}
}
