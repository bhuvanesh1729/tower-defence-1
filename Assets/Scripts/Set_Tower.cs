using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Set_Tower : MonoBehaviour {

	public GameObject prefab;
	public Renderer rend;
	public Material startmat;
	public Material mat;
	// Use this for initialization
	void Start () {
		rend = GetComponent<Renderer> ();
		startmat = rend.material;
	}
	
	// Update is called once per frame
	void Update () {
		
		
		
	}

	void OnMouseOver()
	{
		if(!GetComponent<Tile_Taken>().isTaken)
		rend.material = mat;
	}
	void OnMouseDown()
	{
		if (!GetComponent<Tile_Taken> ().isTaken) {
			GetComponent<Tile_Taken> ().isTaken = true;
			prefab = GameObject.FindGameObjectWithTag ("Game_manager").GetComponent<Income> ().prefab;
			GetComponent<Tile_Taken> ().tower=prefab;
			Vector3 t = new Vector3 (0, 1, 0);
			Instantiate (prefab,transform.position+t,Quaternion.identity);


		}
	}
	void OnMouseExit()
	{
		rend.material = startmat;
	}



}
