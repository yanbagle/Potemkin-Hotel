using UnityEngine;
using System.Collections;

public class LaptopScanner : MonoBehaviour {
	
	public WrongCardScript wrongCard;
	public RightCardScript rightCard;
	
	// Use this for initialization
	void Start () {
		GameObject wObj = GameObject.Find("wrong card");
		wrongCard = wObj.GetComponent<WrongCardScript>();
		GameObject rObj = GameObject.Find("THE room card");
		rightCard = wObj.GetComponent<RightCardScript>();
	}
	
	// Update is called once per frame
	void Update () {
		if(wrongCard.hasCard == true){
			
		
		}
	}
}
