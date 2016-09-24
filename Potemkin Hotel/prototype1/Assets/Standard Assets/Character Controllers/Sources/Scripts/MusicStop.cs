using UnityEngine;
using System.Collections;

public class MusicStop : MonoBehaviour {

	public bool stopMusic = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other){
		stopMusic = true;

	}
}
