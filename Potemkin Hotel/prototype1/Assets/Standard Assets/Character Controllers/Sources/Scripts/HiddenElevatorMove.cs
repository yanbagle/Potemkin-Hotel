using UnityEngine;
using System.Collections;

public class HiddenElevatorMove : MonoBehaviour {
	
	Vector3 speed = new Vector3(0,2,0);
	PlayerInArea isInArea;
	HiddenButtonElevatorScript button;


	
	// Use this for initialization
	void Start () {
		GameObject triggerObject = GameObject.Find ("hiddenElevatorTrigger");
		isInArea = triggerObject.GetComponent<PlayerInArea>();
		
		GameObject buttonObject = GameObject.Find ("hiddenElevatorButton");
		button = buttonObject.GetComponent<HiddenButtonElevatorScript>();
		
	}
	
	// Update is called once per frame
	void Update () {
		if(button.animationFinished && button.goingUp == true){
			moveUp();
		}

		if(!button.animationFinished && button.goingUp == false){
			moveDown();
		}

	}
	
	void moveUp(){
		rigidbody.velocity = speed;	
		rigidbody.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationZ | RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionZ;
		
		if(rigidbody.position.y > 13.8){
			rigidbody.velocity = new Vector3(0,0,0);
		}

		
		
	}

	void moveDown(){
		rigidbody.velocity = -speed;	
		rigidbody.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationZ | RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionZ;
		
		if(rigidbody.position.y < 0.17){
			rigidbody.velocity = new Vector3(0,0,0);
		}
		
		
		
	}
	
	
	
}
