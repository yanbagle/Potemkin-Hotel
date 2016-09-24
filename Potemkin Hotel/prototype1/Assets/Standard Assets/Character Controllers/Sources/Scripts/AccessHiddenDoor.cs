using UnityEngine;
using System.Collections;

public class AccessHiddenDoor : MonoBehaviour {
	
	PuzzleCheck puzzleCheck;
	public bool hiddenDoorAccessible = false;
	public bool doorOpening = false;
	Vector3 openPosition;
	Vector3 pushedIn;
	public bool firstAnimation = true;
	public int timer = 0;

	bool playedAudio = false;
	
	// Use this for initialization
	void Start () {

		/*
		GameObject puzzleObject = GameObject.Find("ScriptHolderObject");
		puzzleCheck = puzzleObject.GetComponent<PuzzleCheck>();
		*/
		hiddenDoorAccessible = false;

		float x = transform.position.x;
		float y = transform.position.y;
		float z = transform.position.z;
		float newX = (float)(x + 2.8);
		openPosition = new Vector3(newX,y,z);
		float newZ = (float)(z - 0.4);
		pushedIn = new Vector3(x,y,newZ);
	}
	
	// Update is called once per frame
	void Update () {



		// if player card has been destroyed, then the door is accessible
		if (GameObject.Find ("player card") == null) {
			hiddenDoorAccessible = true;
		}


		if(doorOpening){
			openDoor();
			if(playedAudio == false){
				playedAudio = true;
				audio.Play();

			}
		}
		
	}
	
	void OnMouseDown(){
		if(hiddenDoorAccessible){
			doorOpening = true;
		}
		
	}
	
	void openDoor(){
		timer++;
		if(firstAnimation){
			transform.position = Vector3.Lerp(transform.position, pushedIn, Time.deltaTime);
			if(timer > 40){
				firstAnimation = false;
			}
		}
		else{
			transform.position = Vector3.Lerp(transform.position, openPosition,  Time.deltaTime);
		}
		
		
		
	}
	
	
	
}
