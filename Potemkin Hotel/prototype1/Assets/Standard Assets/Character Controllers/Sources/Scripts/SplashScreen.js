#pragma strict

public var heldObject : GameObject;
public var itemHeld = true;
var player1 : GameObject;
var itemHeldsec = false;
var pickUpDistance = 3.0;
var distance : float;
var rotAxisMark = 0;
var rotAxis : Vector3 = Vector3.up;
var lastMB2 : boolean;

var start: boolean;

function Start () {
	player1 = gameObject.FindGameObjectWithTag("Player");
	itemHeld = true;
	itemHeldsec = true;
	start = false;
	heldObject = gameObject;
    heldObject.transform.parent = player1.transform;
    heldObject.transform.position.y = GameObject.FindGameObjectWithTag("Player").transform.position.y + 1;
    heldObject.GetComponent(Rigidbody).isKinematic = true;
}

function Update () {


	
	
	if (Input.GetMouseButtonDown(0) && itemHeld && itemHeldsec) {
       start = true;
       rotAxis = Vector3(1,0,0);
       transform.rotation = transform.rotation * Quaternion.AngleAxis(2, rotAxis);
       heldObject.transform.parent = null;
       heldObject.GetComponent(Rigidbody).isKinematic = false;
       //heldObject.rigidbody.useGravity = true;
        //heldObject = null;
       // itemHeld = false;
 
    }
    
    if(!start){
    	distance = Vector3.Distance(this.transform.position,player1.transform.position);
    
    }

}


    





















    