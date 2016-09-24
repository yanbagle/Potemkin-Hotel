using UnityEngine;
using System.Collections;

public class ElevatorMove : MonoBehaviour {

	PuzzleCheck puzzleCheck;
	ElevatorStatus elevatorFloor;
	public ElevatorButton eb;
	
	Vector3 speed = new Vector3(0,2,0);
	public bool stop = false;
	public bool elevatorWorking = false;
	
	// Use this for initialization
	void Start () {
		
		GameObject puzzleObject = GameObject.Find ("ScriptHolderObject");
		puzzleCheck = puzzleObject.GetComponent<PuzzleCheck>();
	
		GameObject floorObject = GameObject.Find("Elevator");
		elevatorFloor = floorObject.GetComponent<ElevatorStatus>();
		
		GameObject buttonObject = GameObject.Find ("elevatorbutton");
		eb = buttonObject.GetComponent<ElevatorButton>();
		
	}
	
	// Update is called once per frame
	void Update () {
		if(puzzleCheck.puzzle1complete == true){
		   lobbyToSecondFloor();
		}
		
	}
	
	
	public void lobbyToSecondFloor(){
		if(stop == false){

			rigidbody.velocity = speed;
			rigidbody.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationZ;
			if(rigidbody.position.y > (float)5.3){
				stop = true;
				rigidbody.velocity = new Vector3(0,0,0);
				elevatorFloor.setCurrentFloor(2);	
				eb.setIsElevatorLeftOpening(true);
				eb.setIsElevatorRightOpening(true);
				
			}
			
		}
	
	}
	
	
	
	
	
}
