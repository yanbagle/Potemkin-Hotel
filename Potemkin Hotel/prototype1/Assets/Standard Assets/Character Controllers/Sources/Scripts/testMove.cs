using UnityEngine;
using System.Collections;

public class testMove : MonoBehaviour {
	
	public Vector3 newP;
	public Vector3 B;
	
	// Use this for initialization
	void Start () {
		
		newP = transform.position;
		B = new Vector3(-15,2,-9);
		
		
	}
	
	// Update is called once per frame
	void Update () {
		newP = B;
		transform.position = Vector3.Lerp(transform.position, newP, Time.deltaTime );
		
	}
}
