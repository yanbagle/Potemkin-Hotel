using UnityEngine;
using System.Collections;

public class EnterOwnerRoom : MonoBehaviour {
	
	public GameObject brokenLightObject = null;
	BrokenLight lightScript;
	
	
	// Use this for initialization
	void Start () {
		lightScript = brokenLightObject.GetComponent<BrokenLight>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnTriggerEnter(Collider other) {
		lightScript.flicker(true);
	}
	
	void OnTriggerExit(Collider other) {
		lightScript.flicker(false);
	}	
	
	
}
