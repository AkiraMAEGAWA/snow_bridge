using UnityEngine;
using System.Collections;

public class Break_Down : MonoBehaviour {

	public GameObject field;

	void OnCollisionEnter(Collision collision){
	    Destroy (this.gameObject);
	    Rigidbody first_field = field.AddComponent<Rigidbody>();

	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
