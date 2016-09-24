using UnityEngine;
using System.Collections;

public class PuzzleCheck : MonoBehaviour {
	
	public bool puzzle1complete = false;
	public bool puzzle2complete = false;
	public bool puzzle3complete  = false;
	public bool puzzle4complete  = false;
	public bool puzzle5complete  = false;
	
	ElevatorButtonInside elevatorButton;
	Key1Script key;

	
	
	// Use this for initialization
	void Start () {
		GameObject buttonObject = GameObject.Find ("Elevator");
		elevatorButton = buttonObject.GetComponent<ElevatorButtonInside>();
		
		GameObject keyObject = GameObject.Find("key1");
		key = keyObject.GetComponent<Key1Script>();


		
	}
	
	// Update is called once per frame
	void Update () {
		if(elevatorButton.returnIsPush() && key.hasKey1() && elevatorButton.isLeftClosed() && elevatorButton.isRightClosed()){
			puzzle1complete = true;
		}


	
		
		
	}
	
	
	
}
