using UnityEngine;
using System.Collections;

public class fall : MonoBehaviour {
	public float moveSpeed = 0f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(Vector3.down * moveSpeed * Time.deltaTime);
		moveSpeed += 0.4f;
	}
}
