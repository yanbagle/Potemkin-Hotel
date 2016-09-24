#pragma strict

var red: Red;
var blue: Blue;
var green: Green;
var artist: Artist1;

public var strokeAmount = 1;

private var cursorWidth = 32;
private var cursorHeight = 32;

public var redImage: Texture2D;
public var greenImage: Texture2D;
public var blueImage: Texture2D;

public var isPainting = false;
public var donePainting = false;

public var paintingTime = 0;


function Start () {

	
	
	var r = GameObject.Find("paint bucket - red");
	var g = GameObject.Find("paint bucket - green");
	var b = GameObject.Find("paint bucket - blue");
	
	var a = GameObject.Find("human_normal_artist2");
	
	artist = a.GetComponent("Artist1");
	red = r.GetComponent("Red");
	blue = b.GetComponent("Blue");
	green = g.GetComponent("Green"); 
	
	isPainting = false;
	
}

function Update(){
	
	if(Input.GetMouseButtonDown(1)){//done painting
		donePainting = true;
		
	}
	if(artist.talkedTo && (red.hasPaint || blue.hasPaint || green.hasPaint)){
		isPainting = true;
	}
    if(Input.GetMouseButton(0) && isPainting && donePainting == false){
    	paintingTime++;
    	
    	for(var i = 0; i < strokeAmount; i++){
		       var hit: RaycastHit;
		       var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		       if(Physics.Raycast(ray, hit)){
			         var paint = GameObject.CreatePrimitive(PrimitiveType.Sphere);
			         var worldSpace = hit.point;
					 paint.transform.position = new Vector3(worldSpace.x - 0.001, worldSpace.y, worldSpace.z);
				
					 var scale = 0.05;
					 paint.transform.localScale = new Vector3(scale,scale,scale);
					 //plane.transform.eulerAngles = new Vector3(0,0,90);
					paint.collider.enabled = false;
					
					 if(green.hasPaint){
						paint.renderer.material.color = Color.green;
					 }
					 else if(blue.hasPaint){
						 paint.renderer.material.color = Color.blue;
					 }
					 else if(red.hasPaint){
					 	paint.renderer.material.color = Color.red;
					 
					 }
				 	
				 
		       }
       
       }
       
       
    }
    
    
    
}

function OnGUI(){
	if(donePainting == false){
		 if(red.hasPaint){
			GUI.DrawTexture( Rect(Input.mousePosition.x, Screen.height - Input.mousePosition.y, cursorWidth, cursorHeight), redImage);
		 }
		 else if(green.hasPaint){
			 GUI.DrawTexture( Rect(Input.mousePosition.x, Screen.height - Input.mousePosition.y, cursorWidth, cursorHeight), greenImage);
		 }
		 else if(blue.hasPaint){
		      GUI.DrawTexture( Rect(Input.mousePosition.x, Screen.height - Input.mousePosition.y, cursorWidth, cursorHeight), blueImage);
		 
		 }
	
	}
	 

}










