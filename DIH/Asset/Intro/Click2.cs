using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click2 : MonoBehaviour {

	public GameObject cube;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnMouseUp () {

		Debug.Log ("d2");
		GameObject.Find("BTN2").GetComponent<AudioSource> ().Play ();

	}
}
