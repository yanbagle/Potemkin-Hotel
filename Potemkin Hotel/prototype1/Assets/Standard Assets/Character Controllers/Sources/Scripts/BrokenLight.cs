using UnityEngine;
using System.Collections;

public class BrokenLight : MonoBehaviour {
	
	public int lightTimer = 0;
	public bool beat = false;
	public int stopFactor;
	
	public bool stopFlicker = false;
	public PlayerInArea area;

	public PlayerStatus player;

	
	// Use this for initialization
	void Start () {
		GameObject platformObject = GameObject.Find("hiddenElevatorTrigger");
		area = platformObject.GetComponent<PlayerInArea>();

		player = GameObject.Find("First Person Controller").GetComponent<PlayerStatus>();
	}
	
	// Update is called once per frame
	void Update () {
		if(area.inArea || stopFlicker){
			light.enabled = false;
		}

		if(stopFlicker == false || player.playerCurrentFloor == 5){
			flickLights();
		}
	
		
	}
	
	public void flicker(bool f){
		stopFlicker = f;
		
	} 

	public void flickLights(){
		lightTimer++;
		
		stopFactor = Random.Range(2,5);
		if(lightTimer % stopFactor == 0 && beat == false ){
			if(light != null){
				light.enabled = !light.enabled;
			}
		}
		
		if(lightTimer == 100){
			lightTimer = 0;
			beat = !beat;
		}

	}
}
