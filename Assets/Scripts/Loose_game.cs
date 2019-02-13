using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loose_game : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnCollisionEnter(Collision col)
	{
		if (col.gameObject.tag == "Enemy") {
			Debug.Log ("LooseGame");
			Destroy (col.gameObject);
		}
	}
}
