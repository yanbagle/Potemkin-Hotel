using UnityEngine;
using System.Collections;

public class GuardScript : MonoBehaviour {
	
	public bool firstClipPlayed = false;
	
	
	public float smooth = 2.0f;
	public float turnAngle = 90.0f;
	public float turnSpeed = 3.5f;
	public Vector3 turnPosition;
	public Vector3 defaultPos;
	
	public bool turned = false;
	
	public Vector3 eulerAngleVelocity = new Vector3(0, 100, 0);
	public Vector3 speed= new Vector3(5,0,0);
	public Quaternion deltaRotation;
	
	public AudioSource guard1;
	
	
	public bool moveAway = false;
	
	public float headYPos;
	public int jumpTimer;
	
	public bool moved;
	public bool secondTurn;
	
	// Use this for initialization
	void Start () {
		deltaRotation = Quaternion.Euler(eulerAngleVelocity * Time.deltaTime * turnSpeed);
		
		AudioSource []  aSources = GetComponents<AudioSource>();
		guard1 = aSources[0];
		
		foreach (Transform child in transform) {
			if(child.name == "pCylinder2"){
				headYPos = child.position.y;
			}
			
		}
		moved = false;
		secondTurn = false;
		
	}
	
	// Update is called once per frame
	void Update () {
		if (!moved) {
			jumpTimer++;
		}
		
		if(guard1.isPlaying){
			if(jumpTimer % 3 == 0){
				moveHeadUp();
				
			}
			if (jumpTimer % 6 == 0){
				moveHeadDown();
				
			}
			
		}
		else{
			moveHeadDown();
		}
		
		if(guard1.isPlaying == false && firstClipPlayed){
			moveAway = true;
			foreach(GameObject obj in GameObject.FindGameObjectsWithTag("Guard")) {
				Destroy(obj);
			}
		}
		
		if(moveAway){
			moveAwayAnim(); 
		}
		
		
		if(turned && !moved){
			rigidbody.velocity = speed;
			rigidbody.constraints = RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationZ;
			if (transform.position.x > -6) {
				moved = true;
			}
		}
		if (moved && !secondTurn) {
			if(rigidbody.transform.rotation.y < .999){ //
				rigidbody.MoveRotation(rigidbody.rotation * deltaRotation);
			}
			else {
				secondTurn = true;
			}
		}
		
	}
	
	
	void OnMouseDown(){
		if(firstClipPlayed == false){
			firstClipPlayed = true;
			guard1.Play();
		}
	}
	
	void moveAwayAnim(){
		
		if(rigidbody.transform.rotation.y < 0.7 && !turned){ //
			rigidbody.MoveRotation(rigidbody.rotation * deltaRotation);
		}
		else{
			turned = true;
		}
	}
	
	
	
	void moveHeadUp(){
		foreach (Transform child in transform) {
			if(child.name == "pCylinder2"){
				child.position = new Vector3(child.position.x, headYPos + (float)0.2, child.position.z);
			}
		}
		
	}
	
	void moveHeadDown(){
		
		foreach (Transform child in transform) {
			if(child.name == "pCylinder2"){
				child.position = new Vector3(child.position.x, headYPos , child.position.z);
				
			}
		}
	}
	
	
	
	
}
