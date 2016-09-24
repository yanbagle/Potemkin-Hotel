using UnityEngine;
using System.Collections;

public class ElevatorButton2ndFloor : MonoBehaviour {
	
	public bool playBrokenElevatorSoundFirst = false;
	public bool breakTheElevator = false;
	public int flickerNum = 20;
	private GameObject elevatorLights = null;
	private LightFlicker lightFlicker;
	public bool lightsOff = false;
	
	// Use this for initialization
	void Start () {
		elevatorLights = GameObject.Find("Elevator Light");
		lightFlicker = elevatorLights.GetComponent<LightFlicker>();
	}
	
	// Update is called once per frame
	void Update () {
		if(lightFlicker.done){
			lightFlicker.turnLightsOff();
		}
		
	}
	
	void OnMouseDown(){
		playSomeNoise();
		
		if(lightFlicker.done == false){
			lightFlicker.setNum(flickerNum);
			lightFlicker.isStarting(true);
			
		}

	}
	
	
	void playSomeNoise(){
		if(playBrokenElevatorSoundFirst == false){
			breakTheElevator = true;
		}
		if(playBrokenElevatorSoundFirst == true){
			audio.Play();//play broken button sound
		}
		playBrokenElevatorSoundFirst = true;		
	}
	
	
}
