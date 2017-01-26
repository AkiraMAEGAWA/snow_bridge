using UnityEngine;
using System.Collections;

public class viveration : MonoBehaviour {
    float time = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		time += Time.deltaTime;
		transform.Translate (new Vector3 (0, Mathf.Cos(0.5f * time), 0) * Time.deltaTime);
	}
}
