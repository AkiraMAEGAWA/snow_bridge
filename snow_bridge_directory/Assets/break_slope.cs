using UnityEngine;
using System.Collections;

public class break_slope : MonoBehaviour {


	public GameObject slope;

	void OnCollisionEnter(Collision collision){
		Destroy (this.gameObject);
		Rigidbody middle_slope = slope.AddComponent<Rigidbody>();

	}

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}
}
