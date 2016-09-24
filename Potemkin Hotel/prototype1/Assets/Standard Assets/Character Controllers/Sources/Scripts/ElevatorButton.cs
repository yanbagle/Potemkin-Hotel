using UnityEngine;
using System.Collections;

public class ElevatorButton : MonoBehaviour {

	public bool elevatorLeftOpening = false;
	public bool elevatorLeftClosing = false;
	public bool elevatorRightOpening = false;
	public bool elevatorRightClosing = false;

	void OnMouseDown(){
		elevatorLeftOpening = true;
		elevatorRightOpening = true;
		audio.Play();
	}
	
	public bool isElevatorLeftOpening(){
		return elevatorLeftOpening;
	}
	
	public bool isElevatorRightOpening(){
		return elevatorRightOpening;
	
	}
	
	public void setIsElevatorLeftOpening(bool opening){
		elevatorLeftOpening = opening;
	}
	
	public void setIsElevatorRightOpening(bool opening){
		elevatorRightOpening = opening;
	}
	
	void Update(){
		
	
	}

}
