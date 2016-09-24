using UnityEngine;
using System.Collections;

public class RightElevatorDoorFirst : MonoBehaviour {
	
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
	public int count;
	
	// Use this for initialization
	void Start () {
		GameObject buttonObject = GameObject.Find ("elevatorbutton");
		eb = buttonObject.GetComponent<ElevatorButton>();
		
		GameObject buttonObjectInside = GameObject.Find ("Elevator");
		ebi = buttonObjectInside.GetComponent<ElevatorButtonInside>();
		
		GameObject elevatorObject = GameObject.Find("Elevator");
		elevatorCurrentFloor = elevatorObject.GetComponent<ElevatorStatus>();
		
		closedZ = transform.position.z;
		openZ = (float) -6;
		staticX = transform.position.x;
		
	}
	
	void recordNewPosition(){
		y = transform.position.y;
		openPosition = new Vector3(staticX,y,openZ);
		closedPosition = new Vector3(staticX, y, closedZ);
		
	}
	
	// Update is called once per frame
	void Update () {
		
		
		if(eb.isElevatorRightOpening() && elevatorCurrentFloor.currentFloor == 1){
			if(takesNewPos  ==  false){
				takesNewPos = true;
				recordNewPosition();
			}
			else{
				newPosition = openPosition;
				//Lerp takes in the beginning position and goes to the newPosition
				transform.position = Vector3.Lerp(transform.position, newPosition, Time.deltaTime );
				time++;
				if(time == 100){//detecting the finished opening animation, because I can't figure out out how to do it otherwise 
					eb.setIsElevatorRightOpening(false);
					time = 0;
					takesNewPos = false;
				}	
				
			}
			
		}
		
		else if(ebi.isElevatorRightClosing() && elevatorCurrentFloor.currentFloor == 1){
			if(takesNewPos == false){
				takesNewPos = true;
				recordNewPosition();
			}
			else{
				newPosition = closedPosition;
				transform.position = Vector3.Lerp(transform.position, newPosition, Time.deltaTime);
				time++;
				if(time == 400){
					ebi.setIsElevatorRightClosing(false);
					ebi.setRightClosed(true);
					time = 0;
					takesNewPos = false;
				}
				
			}
			
		}
		
		
		
	}
}

