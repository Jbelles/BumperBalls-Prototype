using UnityEngine;
using System.Collections;

public class SphereColor : MonoBehaviour {

	// Use this for initialization
	void Start () {
		//assign random colors to other spheres
		if (transform.gameObject.name == "Player")
			transform.GetComponent<Renderer>().material.color = Color.blue;
		else if (transform.name == "Bumper")
			transform.GetComponent<Renderer> ().material.color = Color.yellow;
		else
			transform.GetComponent<Renderer>().material.color = new Color(Random.Range(0.0f,1.0f),Random.Range(0.0f,1.0f),Random.Range(0.0f,0.5f)); //make sure the random colors arent too close to the player's color
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
