using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {

	public float radius;
	RaycastHit[] hits;
	public GameObject  enemy;
	float distance=999999;
	float maxdistance=999999;
	public GameObject prefab;
	public  float cooldown;
	float maxcooldown;
	public bool isbomb;
	public GameObject temp;

	void Start () {
		maxcooldown=cooldown;
		InvokeRepeating ("FindNearestEnemy", 0f, 0.5f);
	}
	void FindNearestEnemy()
	{
		
		hits=Physics.SphereCastAll (transform.position, radius,transform.forward,0f);
		foreach (RaycastHit hit in hits) {
			if (hit.collider.gameObject.tag == "Enemy") {
				float t = Vector3.Distance (hit.collider.gameObject.transform.position, transform.position);
				if (t < distance) {
					distance = t;
					if (maxdistance > t) {
						maxdistance = t;
						enemy = hit.collider.gameObject;
					}
				}
			}
		}
		if (enemy != null) {
			if (Vector3.Distance (enemy.transform.position, transform.position) > radius) {
				distance = 999999;
				maxdistance = 999999;
				enemy = null;
			}
		}



	}
	
	// Update is called once per frame
	void Update () {
		
		if (enemy != null) {
			transform.LookAt (enemy.transform);
			cooldown -= Time.deltaTime;
			if(cooldown<=0)
			{
				
				temp = Instantiate (prefab, transform.GetChild (0).transform.position, Quaternion.identity);
				if(isbomb)
				temp.GetComponent<bomb_movement> ().target = enemy;
				else
					temp.GetComponent<bullet_movement> ().target = enemy;
				cooldown = maxcooldown;
			}
		}
	}


	void OnDrawGizmosSelected()
	{
		Gizmos.color = Color.red;

		Gizmos.DrawWireSphere (transform.position, radius);
	}


}
