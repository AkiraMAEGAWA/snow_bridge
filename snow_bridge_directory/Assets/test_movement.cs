using UnityEngine;
using System.Collections;

public class test_movement : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		// 手前から奥にかけてがz軸
		if (Input.GetKey (KeyCode.UpArrow)) {
			transform.GetComponent<Rigidbody>().AddForce (0, 0, 5);
		}
		if (Input.GetKey (KeyCode.DownArrow)) {
			transform.GetComponent<Rigidbody>().AddForce (0, 0, -5);
		}
		// 横方向がx軸
		if (Input.GetKey (KeyCode.RightArrow)) {
			transform.GetComponent<Rigidbody>().AddForce (500, 0, 0);
		}
		if (Input.GetKey (KeyCode.LeftArrow)) {
			transform.GetComponent<Rigidbody>().AddForce (-500, 0, 0);
		}
		if (Input.GetKey (KeyCode.Space)) {
			transform.GetComponent<Rigidbody>().AddForce (0, 100, 0);
		}
	}

}
