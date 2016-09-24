using UnityEngine;
using System.Collections;

public class paint : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0)){
			GameObject player = GameObject.FindGameObjectWithTag("Player");
			GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
			cube.transform.position = new Vector3(player.transform.position.x, player.transform.position.y, (float)27.89671);
			float scale = (float) 0.08310366;
			cube.transform.localScale = new Vector3(scale,scale,scale);
			cube.renderer.material.color = Color.green;
			
			
		}
	}
	

}
