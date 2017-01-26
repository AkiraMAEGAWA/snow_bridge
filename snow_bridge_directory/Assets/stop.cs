using UnityEngine;
using System.Collections;

public class stop : MonoBehaviour {
    private help_enemy script;
	void OnCollisionEnter(Collision c){
		script.enabled = false;
	}

	// Use this for initialization
	void Start () {
	  
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (Vector3.forward * 10 * Time.deltaTime);
	}
}
