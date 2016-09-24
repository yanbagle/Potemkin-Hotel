#pragma strict
var AudioFile : AudioClip;

function Start () {

}

function Update () {
	if(Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.S) ){
		audio.clip = AudioFile;
		audio.loop = true;
		audio.Play();
		
	}
	
	if(Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.D) || Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.S) ){
		audio.Stop();
	
	}
}