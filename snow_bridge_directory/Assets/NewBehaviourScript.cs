using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {
	
	public Transform trans;
	void helloWorld (){
		Debug.Log ("helloWorld");
	}
	public float moveSpeed = 3f;
	public float turnSpeed = 50f;
	// Use this for initialization
	void Start () {
		Debug.Log (trans.position);
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log (trans.position);
		if (Input.GetKey (KeyCode.D)) {
			transform.Translate (Vector3.right * moveSpeed * Time.deltaTime);
		}
		if (Input.GetKey (KeyCode.W)) {
			transform.Translate (Vector3.forward * moveSpeed * Time.deltaTime);
		}
		if (Input.GetKey (KeyCode.A)) {
			transform.Translate (Vector3.left * moveSpeed * Time.deltaTime);
		}
		if (Input.GetKey (KeyCode.S)) {
			transform.Translate (-Vector3.forward * moveSpeed * Time.deltaTime);
		}
		if (Input.GetButton ("Jump")) {
			transform.Translate (Vector3.up * moveSpeed * 2 * Time.deltaTime);
		}
		if (Input.GetKey (KeyCode.RightArrow)) {
			transform.Rotate (Vector3.up * turnSpeed * Time.deltaTime);
		}
		if (Input.GetKey (KeyCode.LeftArrow)) {
			transform.Rotate (Vector3.up * -turnSpeed * Time.deltaTime);
		}

	}
}
