using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class Enemy_cotroller : MonoBehaviour {

	public GameObject Base;
	public int speed;
	NavMeshAgent agent;

	// Use this for initialization
	void Start () {
		
		agent=GetComponent<NavMeshAgent>();
	}
	
	// Update is called once per frame
	void Update () {
		
		Base = GameObject.FindGameObjectWithTag ("Base");

		agent.destination = Base.transform.position;
	}

}
