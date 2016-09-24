using UnityEngine;
using System.Collections;

public class TurnOffPartyLights : MonoBehaviour {
	
	public PlayerStatus ps;
	// Use this for initialization
	void Start () {
		GameObject playerObject = GameObject.Find ("First Person Controller");
		ps = playerObject.GetComponent<PlayerStatus>();
		
	}
	
	// Update is called once per frame
	void Update () {
		if(ps.playerCurrentFloor == 4){
			light.enabled = true;
		}
		else{
			light.enabled = false;
		}
	}
}
