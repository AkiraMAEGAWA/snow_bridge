using UnityEngine;
using System.Collections;

public class up : MonoBehaviour {
	public int strength = 0;  
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (Vector3.up * strength * 100 * Time.deltaTime);
	}
}
