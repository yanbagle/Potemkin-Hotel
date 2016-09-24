using UnityEngine;
using System.Collections;

public class PlayerInArea : MonoBehaviour {
	
	public bool inArea = false;
	
	// Use this for initialization
	void Start () {
		//inArea = true;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnTriggerEnter(Collider other) {
		inArea = true;
	}
	
	void OnTriggerExit(Collider other) {
		//inArea = false;
	}
	
	
}
