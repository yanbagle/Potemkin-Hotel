#pragma strict

function Start () {

}

function Update () {

}

function OnTriggerEnter(other : Collider){
	Destroy(GameObject.Find("old lamp"));
	Destroy(GameObject.Find("old lamp"));
}