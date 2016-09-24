using UnityEngine;
using System.Collections;

public class LeftElevatorDoorFirst : MonoBehaviour {
	
	public ElevatorButton eb;
	public ElevatorButtonInside ebi;
	public ElevatorStatus elevatorCurrentFloor;
	public Vector3 newPosition;
	public Vector3 openPosition;
	public Vector3 closedPosition;
	public float y;
	public float staticX;
	public float closedZ;
	public float openZ;
	public int time = 0;
	public bool takesNewPos = false;
	
	// Use this for initialization
	void Start () {
		GameObject buttonObject = GameObject.Find ("elevatorbutton");
		eb = buttonObject.GetComponent<ElevatorButton>();
		
		GameObject buttonObjectInside = GameObject.Find ("Elevator");
		ebi = buttonObjectInside.GetComponent<ElevatorButtonInside>();
		
		GameObject elevatorObject = GameObject.Find("Elevator");
		elevatorCurrentFloor = elevatorObject.GetComponent<ElevatorStatus>();
		
		closedPosition = transform.position;//closedPosition is the original position
		
		closedZ = transform.position.z;
		openZ = (float) -13.2;
		staticX = transform.position.x;
	}
	
	void recordNewPosition(){
		y = transform.position.y;
		openPosition = new Vector3(staticX,y,openZ);
		closedPosition = new Vector3(staticX, y, closedZ);
	}
	
	// Update is called once per frame
	void Update () {
		if(elevatorCurrentFloor.currentFloor == 1){
			if(eb.isElevatorLeftOpening() ){
				if(takesNewPos == false){
					takesNewPos = true;
					recordNewPosition();
				}
				newPosition = openPosition;
				//Lerp takes in the beginning position and goes to the newPosition
				transform.position = Vector3.Lerp(transform.position, newPosition, Time.deltaTime);
				time++;
				if(time == 100){//detecting the finished closing animation, because I can't figure out out how to do it otherwise 
					eb.setIsElevatorLeftOpening(false);
					time = 0;
					takesNewPos = false;
				}
			}
			else if(ebi.isElevatorLeftClosing()){
				if(takesNewPos == false){
					takesNewPos = true;
					recordNewPosition();
				}
				newPosition = closedPosition;
				transform.position = Vector3.Lerp(transform.position, newPosition, Time.deltaTime);
				time++;
				if(time == 400){
					ebi.setIsElevatorLeftClosing(false);
					ebi.setLeftClosed(true);
					takesNewPos = false;
				}
			}
		}
		
	}//end update
	
	
}
