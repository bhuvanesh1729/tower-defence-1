using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet_movement : MonoBehaviour {

	public GameObject target; 
	public float speed;
	public float damage;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (target == null) {
			Destroy (this.gameObject);
			return;
		}
		transform.LookAt (target.transform);
		transform.Translate (Vector3.forward * speed * Time.deltaTime);
	}

	void OnCollisionEnter(Collision col)
	{
		if (col.gameObject.tag == "Enemy") {
			col.gameObject.GetComponent<Health>().health -= damage;
			Destroy (this.gameObject);
		}
	}
}
