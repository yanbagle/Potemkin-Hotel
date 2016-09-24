#pragma strict


public var npcArtist: Artist1;

function Start () {
	npcArtist = GameObject.Find("human_normal_artist2").GetComponent("Artist1");
}

function Update () {
	if(npcArtist.donePainting){
		Destroy(gameObject);
	}
}