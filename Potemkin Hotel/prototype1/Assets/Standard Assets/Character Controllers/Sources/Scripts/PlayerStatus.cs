using UnityEngine;
using System.Collections;

public class PlayerStatus : MonoBehaviour {
	public bool debug;
	public int playerCurrentFloor = 1;
	
	// Use this for initialization
	void Start () {
		debug = true; //CHANGE THIS TO FALSE TO START AT BEGINNING OF GAME
		if (!debug) {
			transform.position = new Vector3(20,2,1);
			transform.rotation = Quaternion.Euler(0,275,0);
		}
	}
	
	// Update is called once per frame
	void Update () {
		if(transform.position.y > 1.1 && transform.position.y < 8){
			playerCurrentFloor = 1;
		}
		else if(transform.position.y > 8 && transform.position.y < 15){
			playerCurrentFloor = 2;
		
		}
		else if(transform.position.y > 15 && transform.position.y < 21){
			playerCurrentFloor = 3;
		
		}
		else if(transform.position.y > 21 && transform.position.y < 29){
			playerCurrentFloor = 4;
		
		}
		else if(transform.position.y > 29 && transform.position.y < 35){
			playerCurrentFloor = 5;
			
		}
		
	}
}
