using UnityEngine;
using System.Collections;

public class Key1Script : MonoBehaviour {
	
	PictureScript ps;
	bool hasKey = false;
	Vector3 visiblePosition;
	Vector3 hiddenPosition;
	bool moved;
	public bool playedNarration = false;
	
	public Texture2D cursorImage;
	public bool displayIcon = false;
	private int cursorWidth = 32;
	private int cursorHeight = 32;
	
	void Start(){
		GameObject pictureObject = GameObject.Find ("Framed Picture");
		ps = pictureObject.GetComponent<PictureScript>();
		float x = transform.position.x;
		float z = transform.position.z;
		float y = transform.position.y;
		hiddenPosition = new Vector3(x,(float)(y - 1.0),z);
		moved = true;
	}
	
	void Update(){

		if(ps.isPictureClicked() && hasKey == false && moved == true){
			float x = transform.position.x;
			float z = transform.position.z;
			float y = transform.position.y;
			visiblePosition = new Vector3(x,(float)(y - 0.01), z);
			transform.position = visiblePosition;
			if(y < 1.5){
				moved = false;
			}
		}
		
		
	}
	
	void OnMouseDown(){
		hasKey = true;
		transform.position = hiddenPosition;
		if(playedNarration == false){
			playSound();
		}
		playedNarration = true;
	}
	
	
	public void playSound(){
		audio.Play ();
	}
	
	public bool hasKey1(){
		return hasKey;
	
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
