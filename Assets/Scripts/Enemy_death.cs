using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_death : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (GetComponent<Health> ().health <= 0) {
			Destroy (this.gameObject);
		}	
	}
}
