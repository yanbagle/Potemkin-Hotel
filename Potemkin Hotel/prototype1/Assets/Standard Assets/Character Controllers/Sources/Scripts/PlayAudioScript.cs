﻿using UnityEngine;
using System.Collections;

public class PlayAudioScript : MonoBehaviour {
	
	public bool played = false;
	public bool displayHandIcon = false;
	public Texture2D cursorImage;
	private int cursorWidth = 32;
	private int cursorHeight = 32;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnMouseOver(){
		displayHandIcon = true;
	}
	
	void OnMouseExit(){
		displayHandIcon = false;			
	
	}
	
	void OnMouseDown(){
		audio.Play();
	
	}
	
	void OnGUI(){
		if(displayHandIcon){
			GUI.DrawTexture(new Rect(Input.mousePosition.x, Screen.height - Input.mousePosition.y, cursorWidth, cursorHeight), cursorImage);
		}
		
	}
	
	
}