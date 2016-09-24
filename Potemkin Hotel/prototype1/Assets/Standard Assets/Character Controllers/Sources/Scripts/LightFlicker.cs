using UnityEngine;
using System.Collections;

public class LightFlicker : MonoBehaviour {
	public bool start = false;
	public int flickerNum = 0;
	public bool done = false;
	public int lightTimer = 0;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(start && lightTimer % 6 == 0){
			flickerLights();
		}
		lightTimer++;
	}
	
	public void flickerLights(){
		if(light != null){
			light.enabled = !light.enabled;
		}
		flickerNum--;
		if(flickerNum <= 0){
			start = false;
			done = true;
		}
		
	}
	
	public void isStarting(bool s){
		start = s;
	}
	
	public void turnLightsOff(){
		light.enabled = false;
		
	}
	
	public void turnLightsOn(){
		light.enabled = true;
	}
	
	public void setNum(int num){
		flickerNum = num;
	}
	
	public void resetVars(){
		start = false;
		flickerNum = 0;
		lightTimer = 0;
		done = false;
	}
	
	
}
