using UnityEngine;
using System.Collections;

public class ElevatorStatus : MonoBehaviour {
	
	public int currentFloor = 1;//set current floor to the lobby floor (1st floor)
	
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	public void setCurrentFloor(int floor){
		currentFloor = floor;
	}
	
	
	
}
