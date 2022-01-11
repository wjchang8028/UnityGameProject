using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {


		
	}

	void OnMouseEnter () {
		Debug.Log ("dd");
		GameObject.Find("Text").GetComponent<AudioSource> ().Play ();

	}
}
