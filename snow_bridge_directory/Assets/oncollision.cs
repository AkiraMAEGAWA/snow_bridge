using UnityEngine;
using System.Collections;

public class oncollision : MonoBehaviour {
	public GameObject bridge1, enemy1, enemy2;
	// Use this for initialization
	public float timeOut = 1;
	private float timeElapsed;
	private int number = 0;

	void OnCollisionEnter(Collision collision){
		Destroy (this.gameObject);
		Rigidbody bridge_left1 = bridge1.AddComponent<Rigidbody> ();
		up br1 = bridge1.AddComponent<up> ();
		fall fall_enemy1 = enemy1.AddComponent<fall> ();
		fall fall_enemy2 = enemy2.AddComponent<fall> ();



		//fall_enemy.enabled = true; 
	}
    void Start () {
	
	}
	// Update is called once per frame
	void Update () {
	}
}
