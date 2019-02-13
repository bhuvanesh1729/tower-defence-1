using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bomb_movement : MonoBehaviour {

	public GameObject target; 
	public float speed;
	public float damage;
	public float range;
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
		Collider[] cols = Physics.OverlapSphere (this.transform.position, range);
		foreach(Collider coll in cols)
		{
			if (coll.gameObject.tag == "Enemy") {
				coll.gameObject.GetComponent<Health>().health -= damage;
				Destroy (this.gameObject);
			}
		}
	}
}
