using UnityEngine;
using System;
using System.Collections;

public class World : MonoBehaviour {

	public Lemming lemming;
	public Porte porte;
	public Portail portail;

	public int nbLemmings = 20;
	public float intervalPop = 1.0f;

	public float timer;
	public int nbLemmingInScene = 0;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (nbLemmingInScene < this.nbLemmings) {
			if (timer >= intervalPop) {
				this.lemming.gameObject.SetActive (true);
				this.lemming.name = "Lemming" + (nbLemmingInScene + 1);
				GameObject newLemming = Instantiate (this.lemming, this.porte.transform.position, Quaternion.identity) as GameObject;
				timer = 0;
				nbLemmingInScene++;
			}

			timer += Time.deltaTime;
		}
	}
}
