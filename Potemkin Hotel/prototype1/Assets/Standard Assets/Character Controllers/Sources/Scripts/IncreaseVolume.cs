using UnityEngine;
using System.Collections;

public class IncreaseVolume : MonoBehaviour {

	public PlayerStatus player;

	// Use this for initialization
	void Start () {
		player = GameObject.Find("First Person Controller").GetComponent<PlayerStatus>();
	}
	
	// Update is called once per frame
	void Update () {
		if(player.playerCurrentFloor == 5){
			if (audio.volume < 1){
				audio.volume += 1 * Time.deltaTime;
				print (audio.volume + "goingin");
			}	

		}
	}
}
