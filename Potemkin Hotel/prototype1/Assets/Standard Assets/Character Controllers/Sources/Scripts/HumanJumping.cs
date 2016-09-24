using UnityEngine;
using System.Collections;

public class HumanJumping : MonoBehaviour {
	
	public bool isJumping = true;
	public float ySpeed = 0;
	Vector3 speed;
	
	// Use this for initialization
	void Start () {
		speed = new Vector3(0,ySpeed,0);
	}
	
	// Update is called once per frame
	void Update () {
		if(isJumping){
			rigidbody.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationZ;
			rigidbody.velocity = speed;
		}
		if(transform.position.y > 21){
			isJumping = false;
		}
		if(transform.position.y < 20.5){
			isJumping = true;
		}
		//Debug.Log(transform.position.y);
	}
	
	void OnMouseDown(){
		
	
	}
	
	
	
	
	
	
}
