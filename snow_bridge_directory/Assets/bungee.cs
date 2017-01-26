using UnityEngine;
using System.Collections;

public class bungee : MonoBehaviour {
	public Transform target;
	float  dist_y = 0; 
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		dist_y = target.position.y - transform.position.y;
		if(dist_y > 10){
	 	  transform.GetComponent<Rigidbody>().AddForce (0, 37, 0);
		}
	}
}
