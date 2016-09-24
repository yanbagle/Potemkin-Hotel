using UnityEngine;
using System.Collections;

public class SecretRoomSounds : MonoBehaviour {

	public bool playerEntered = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnTriggerEnter(Collider other){
		playerEntered = true;
	}
}
