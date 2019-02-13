using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Health_slider : MonoBehaviour {

	public Slider slider;
	public float _health; 
	// Use this for initialization
	void Start () {
		_health = gameObject.GetComponent<Health> ().health;
		slider.maxValue = _health;
		slider.minValue = 0;
	}
	
	// Update is called once per frame
	void Update () {
		_health = gameObject.GetComponent<Health> ().health;
		slider.value=_health;
	}
}
