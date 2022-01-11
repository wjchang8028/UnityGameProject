using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click3 : MonoBehaviour {
	public GameObject cube;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnMouseUp () {

		Debug.Log ("d3");
		GameObject.Find("BTN3").GetComponent<AudioSource> ().Play ();

	}
}
