using UnityEngine;
using System.Collections;

public class PostImpressionist : MonoBehaviour {
	
	public bool played = false;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnMouseOver(){
		if(played == false){
			audio.Play();
			played = true;
			
		}
		
	
	}
	
	
}
