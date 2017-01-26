using UnityEngine;
using System.Collections;

public class neglect : MonoBehaviour {
	float dist = 0;
	public Transform target;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		dist = Vector3.Distance (target.position, transform.position);
		Debug.Log (dist);
	/*	if (dist > 20) {
			transform.DetachChildren ();
		}*/
	}
}
