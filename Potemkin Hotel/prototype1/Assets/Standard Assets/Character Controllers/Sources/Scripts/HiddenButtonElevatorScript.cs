using UnityEngine;
using System.Collections;

public class HiddenButtonElevatorScript : MonoBehaviour {
	
	public bool buttonPushed = false;
	public bool release = false;
	public bool animationFinished = false;
	public int buttonTimer = 0; 
	public Vector3 originalPosition;
	public Vector3 pushedPosition;
	public Vector3 newPosition;
	public bool reset = false;
	public int finishTime;
	public bool goingUp = false;
	
	// Use this for initialization
	void Start () {
		originalPosition = transform.position;
		float x = transform.position.x;
		float y = transform.position.y;
		float z = transform.position.z;
		float newX = (float) (x + 0.03);
		pushedPosition = new Vector3(newX,y,z);
		finishTime = 80;
	}
	
	// Update is called once per frame
	void Update () {
	


		if(buttonPushed){
			newPosition = pushedPosition;
			doAnimation();
			buttonTimer++;
			if(buttonTimer == 40){
				release = true;
				buttonPushed = false;
			}
		}
		
		if(release){
			newPosition = originalPosition;
			doAnimation();
			buttonTimer++;
			if(buttonTimer == finishTime){
				release = false;
				animationFinished = true;
				buttonTimer = 0;
			}
		}
		
	}
	
	void OnMouseDown(){
		buttonPushed = true;
		animationFinished = false;
		goingUp = !goingUp;
	}
	
	void doAnimation(){
		float dt = (float) (Time.deltaTime * 3.0);
		if(buttonPushed || release){
			transform.position = Vector3.Lerp(transform.position, newPosition, dt);
		}
	}





}
