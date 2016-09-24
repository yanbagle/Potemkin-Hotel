using UnityEngine;
using System.Collections;

public class OpenCloseDoor : MonoBehaviour {
	
	public int open = 0;
	public int close = 1;
	public int currentAnimation;
	
	// Use this for initialization
	void Start () {
		currentAnimation = open;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnMouseDown(){
		if(currentAnimation == open){
			animation.Play("doorOpen");
			currentAnimation = close;
		}
		else{
			animation.Play ("doorClosed");
			currentAnimation = open;
		}
	
	}
}
