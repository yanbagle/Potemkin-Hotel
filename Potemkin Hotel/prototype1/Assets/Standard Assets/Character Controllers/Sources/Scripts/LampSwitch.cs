using UnityEngine;
using System.Collections;

public class LampSwitch : MonoBehaviour {
	
	public GameObject lampLight = null;

	void Start(){
		//lampLight.light.enabled = false;
	}

	private void OnMouseDown(){
		if(lampLight != null && lampLight.light != null){
			lampLight.light.enabled = !lampLight.light.enabled;
			audio.Play ();
		}
	}
	
	
}
