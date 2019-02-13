using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wave_manager : MonoBehaviour {

	public GameObject enemy;
	public Transform position;
	public float cooldown;
	public int wave=1;
	public float maxcooldown;
	// Use this for initialization
	void Start(){
		maxcooldown=cooldown;

		InvokeRepeating ("OnnUpdate",5f,1f);
	}
	// Update is called once per frame
	void OnnUpdate () {
		StartCoroutine ("WaitForS");
		Spawnplayers (wave);
	}

	IEnumerator WaitForS()
	{
		yield return new WaitForSeconds(0.5f);
	}

	void Spawnplayers(int wave)
	{
		for(int i=0;i<wave;i++)
			Instantiate(enemy);
		return;
	}


}
