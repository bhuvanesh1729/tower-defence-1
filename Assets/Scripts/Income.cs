using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Income : MonoBehaviour {

	public float money;
	public GameObject prefab;
	public GameObject[] prefabs;
	public GameObject rotation_fixer;
	// Use this for initialization
	void Start () {
		Instantiate (rotation_fixer);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void one()
	{
		prefab = prefabs [0];
	}

	public void two()
	{
		prefab = prefabs [1];
	}
}
