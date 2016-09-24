using UnityEngine;
using System.Collections;

public class TurnOffLights : MonoBehaviour {
	
	public PlayerInArea area;
	public PlayerStatus playerFloor;
	
	// Use this for initialization
	void Start () {
		GameObject platformObject = GameObject.Find("hiddenElevatorTrigger");
		area = platformObject.GetComponent<PlayerInArea>();

		GameObject playerObj = GameObject.Find("First Person Controller");
		playerFloor = playerObj.GetComponent<PlayerStatus>();

	}
	
	// Update is called once per frame
	void Update () {
		if(area.inArea){
			light.enabled = false;
			
		}

		if(playerFloor.playerCurrentFloor == 2){
			light.enabled = true;

		}
	}
}
