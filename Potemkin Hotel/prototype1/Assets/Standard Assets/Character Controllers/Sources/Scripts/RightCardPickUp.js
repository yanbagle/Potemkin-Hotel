#pragma strict

static var heldObject : GameObject;
static var itemHeld = false;
var player1 : GameObject;
var itemHeldsec = false;
var pickUpDistance = 3.0;
var distance : float;
var rotAxisMark = 0;
var rotAxis : Vector3 = Vector3.up;
var lastMB2 : boolean;

var scanner: CardInScanner;
public var hasRoomCard = false;

function Start () {
	player1 = gameObject.FindGameObjectWithTag("Player");
	
	var s = GameObject.Find("Scanner Trigger");
	scanner = s.GetComponent("CardInScanner");
}

function Update () {

	if (itemHeld) {
		if (Input.GetMouseButton(2) && !lastMB2) {
			if (rotAxis == Vector3.up) {
				rotAxis = Vector3.fwd;
			}
			else if (rotAxis == Vector3.fwd) {
				rotAxis = Vector3(1,0,0);
			}
			else if (rotAxis == Vector3(1,0,0)) {
				rotAxis = Vector3.up;
			}
		}
		if (Input.GetMouseButton(1)){
			transform.rotation = transform.rotation * Quaternion.AngleAxis(2, rotAxis);
		}
		
	}

	distance = Vector3.Distance(this.transform.position,player1.transform.position);
	
	if (Input.GetMouseButtonDown(0) && itemHeld && itemHeldsec && scanner.playerCardScanned) {
        /*
        heldObject.transform.parent = null;
        heldObject.GetComponent(Rigidbody).isKinematic = false;
        heldObject = null;
        itemHeld = false;
        */
        hasRoomCard = true;
        Destroy(heldObject);
    }
    itemHeldsec = itemHeld;
    lastMB2 = Input.GetMouseButton(2);
}

function OnMouseDown() {
    if(!itemHeld && distance<pickUpDistance) {
        heldObject = gameObject;
        heldObject.transform.parent = player1.transform;
        heldObject.transform.position.y = heldObject.transform.position.y +.5;
        heldObject.GetComponent(Rigidbody).isKinematic = true;
        itemHeld = true;
    }
}
    





















    