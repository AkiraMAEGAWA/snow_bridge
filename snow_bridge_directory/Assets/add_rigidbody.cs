using UnityEngine;
using System.Collections;

public class add_rigidbody : MonoBehaviour {

	public GameObject player;
	// Use this for initialization
	void Start () {
	  
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log(player.transform.position.x);
	}  
}
