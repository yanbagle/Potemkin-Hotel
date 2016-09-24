using UnityEngine;
using System.Collections;

public class BreakTheElevator : MonoBehaviour {
	
	public ElevatorButton2ndFloor floorTwoButton;
	
	// Use this for initialization
	void Start () {
		GameObject buttonObject = GameObject.Find("elevatorbutton2");
		floorTwoButton = buttonObject.GetComponent<ElevatorButton2ndFloor>();
	}
	
	// Update is called once per frame
	void Update () {
		if(floorTwoButton.breakTheElevator == true){
			audio.Play();	
		}
		floorTwoButton.breakTheElevator = false;
	}
	
	
}
