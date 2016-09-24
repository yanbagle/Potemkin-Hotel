using UnityEngine;
using System.Collections;

public class ElevatorButtonInside : MonoBehaviour {

	public bool elevatorLeftOpening = false;
	public bool elevatorRightOpening = false;
	
	public bool elevatorRightClosing = false;
	public bool elevatorLeftClosing = false;
	
	public bool rightClosed = false;
	public bool leftClosed = false;
	
	public GameObject elevator;
	PuzzleCheck puzzleCheck;
	
	ElevatorStatus elevatorFloor;
	
	bool isPush = false;
	public Key1Script ks;
	
	private GameObject elevatorLights = null;
	private LightFlicker lightFlicker;
	public int flickerNum;
	public bool playedSound1 = false;
	
	public ElevatorButton2ndFloor floorTwoButton;
	
	public AudioSource[] sounds;
	public AudioSource workingSound;
	public AudioSource brokenSound;
	
	public PlayerStatus playerFloor;

	public bool playerInElevator;
	
	void Start(){
		GameObject puzzleObject = GameObject.Find ("ScriptHolderObject");
		puzzleCheck = puzzleObject.GetComponent<PuzzleCheck>();
		
		elevatorFloor = GetComponent<ElevatorStatus>();
		
		elevatorLights = GameObject.Find("Elevator Light");
		lightFlicker = elevatorLights.GetComponent<LightFlicker>();
		
		flickerNum = 10;
		
		GameObject buttonObject = GameObject.Find("elevatorbutton2");
		floorTwoButton = buttonObject.GetComponent<ElevatorButton2ndFloor>();
		
		GameObject pObject = GameObject.Find ("First Person Controller");
		playerFloor = pObject.GetComponent<PlayerStatus>();
		
		sounds = GetComponents<AudioSource>();
		workingSound = sounds[0];
		brokenSound = sounds[1];

		playerInElevator = false;
	}
	
	void Update(){
		if(lightFlicker.done){
			lightFlicker.turnLightsOff();
		}
	
	}
	
	void OnMouseDown(){

		//After the first challenge's been completed, the elevator will not work
		if(puzzleCheck.puzzle1complete == false){
			GameObject keyObject = GameObject.Find ("key1");
			ks = keyObject.GetComponent<Key1Script>();
			if(ks.hasKey1()) {// && playerInElevator){ //
				elevatorLeftClosing = true;
				elevatorRightClosing = true;		
				isPush = true;
				workingSound.Play();
				
			}
			else if(ks.hasKey1() == false || playerFloor.playerCurrentFloor == 2){
				brokenSound.Play();
				
			}
			
		}
	}


	//void OnTriggerEnter (Collider other) {
		//if (other.gameObject.tag == "Elevator") {
			//playerInElevator = true;
		//}
	//}

	//void OnTriggerExit (Collider other) {
		//if (other.gameObject.tag == "Elevator") {
			//playerInElevator = false;
		//}
	//}


	public bool isElevatorLeftClosing(){
		return elevatorLeftClosing;
	}
	
	public bool isElevatorRightClosing(){
		return elevatorRightClosing;
	}
	
	public bool isRightClosed(){	
		return rightClosed;
	}
	
	public bool isLeftClosed(){
		return leftClosed;
	}
	
	public void setRightClosed(bool r){
		rightClosed = r;
	}
	
	public void setLeftClosed(bool l){
		leftClosed = l;
	}
	
	public void setIsElevatorLeftClosing(bool closing){
		elevatorLeftClosing = closing;
	}
	public void setIsElevatorRightClosing(bool closing){
		elevatorRightClosing = closing;
	}
	
	public bool returnIsPush(){
		return isPush;
	
	}
	
	public void setIsPush(bool push){
		isPush = push;
	
	}
	


	
}
