using UnityEngine;
using System.Collections;

public class PictureScript : MonoBehaviour {
	
	public bool pictureClicked = false;
	public bool playedNarration = false;
	
	public Texture2D cursorImage;
	public bool displayIcon = false;
	private int cursorWidth = 32;
	private int cursorHeight = 32;
	
	void OnMouseDown(){
		pictureClicked = true;	
		if(playedNarration == false){
			playSound();
		}
		playedNarration = true;
		
	}
	

	
	public void playSound(){
		audio.Play ();
	}
	
	public bool isPictureClicked(){
		return pictureClicked;
	}
	
	void OnGUI(){
		if(displayIcon){
			GUI.DrawTexture(new Rect(Input.mousePosition.x, Screen.height - Input.mousePosition.y, cursorWidth, cursorHeight), cursorImage);
		}
		
	}
	
	void OnMouseOver(){
		displayIcon = true;
		
	}
	
	void OnMouseExit(){
		displayIcon = false;
	}
	

	
}
