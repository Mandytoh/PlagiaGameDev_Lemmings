using UnityEngine;
using System.Collections;

public class Plateform : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void onCollisionEnter2D( Collision2D collision) {
		Debug.Log (collision.collider);
		Debug.Log (collision.contacts[0]);
	}
}
