using UnityEngine;
using System.Collections;

public class FlowerScript : MonoBehaviour {
	
	public bool played = false;
	public bool displayIcon = false;
	public Texture2D cursorImage;
	private int cursorWidth = 32;
	private int cursorHeight = 32;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnMouseDown(){
		if(played == false){
			audio.Play ();
			played = true;
		}
	
	}
	
	void OnMouseOver(){
		displayIcon = true;
	
	}
	
	void OnMouseExit(){
		displayIcon = false;
	}
	
	void OnGUI(){
		if(displayIcon){
			GUI.DrawTexture(new Rect(Input.mousePosition.x, Screen.height - Input.mousePosition.y, cursorWidth, cursorHeight), cursorImage);
		}
		
	}
	
	
}
