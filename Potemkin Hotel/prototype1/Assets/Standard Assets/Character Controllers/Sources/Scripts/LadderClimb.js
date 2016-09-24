var chController : Transform;
var inside : boolean = false;
var chMotor: CharacterMotor;
var climb : boolean = false;
var lastClimb : boolean = false;

 private var FPSInput : FPSInputController;
 
  function Start(){
  	FPSInput = GetComponent(FPSInputController);
  	chMotor = GetComponent(CharacterMotor);
  } 
  
  function OnTriggerEnter(Col : Collider){
  	if(Col.gameObject.tag == "Ladder"){
  		//FPSInput.enabled = false;
  		inside = !inside;
  	
  	}
  
  }
  
    function OnTriggerExit(Col : Collider){
  	if(Col.gameObject.tag == "Ladder"){
  		FPSInput.enabled = true;
  		inside = !inside;
  		climb = false;
  	
  	}
  
  }
  
  function Update(){
  	if(inside){
  		chMotor.movement.gravity = 0.0;
  		// Enter/ exit climbing mode
  		if (Input.GetMouseButton(0) && !lastClimb) {
  			if (!climb) {
  				chController.transform.position += (Vector3(0,.5,0));
			}
  			climb = !climb;
  			FPSInput.enabled = !FPSInput.enabled;
  		}
  	}
  	if(((this.transform.position.y<28&&this.transform.position.x<20)||(this.transform.position.y<25)) && inside && climb && (Input.GetKey("w") || Input.GetKey("up"))){
  		chController.transform.position += (Vector3.up/30.0);
  	}
  	else if(inside && climb && (Input.GetKey("s") || Input.GetKey("down")) && chController.transform.position.y > 8.860061){
  		chController.transform.position -= (Vector3.up /15.0);
  		chMotor.movement.gravity = 0.0;
  	}
  	
  		
  
  	
  	
  	if(inside == false){
  		chMotor.movement.gravity = 20.0;
  	
  	}
  	if (Input.GetMouseButton(0)) {
  		lastClimb = true;
  	}
  	else lastClimb = false;
  
  }