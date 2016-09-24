using UnityEngine;
using System.Collections;

public class ElevatorScare : MonoBehaviour {
	
	private GameObject elevatorlight = null;
	private LightFlicker lightFlicker2;
	public bool flickedLights = false;
	
	// Use this for initialization
	void Start () {
		elevatorlight = GameObject.Find("Elevator Light");
		lightFlicker2 = elevatorlight.GetComponent<LightFlicker>();
		
	}
	
	// Update is called once per frame
	void Update () {
		if(flickedLights == false){
			if(transform.position.y > 2.0){
				lightFlicker2.turnLightsOff();
			}
			if(transform.position.y > 2.3){
				lightFlicker2.turnLightsOn();
				flickedLights = true;
			}
		}
		
	}//end update
	
	
	
	
	
	
}
