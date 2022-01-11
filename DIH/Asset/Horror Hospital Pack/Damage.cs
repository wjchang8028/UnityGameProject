using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Damage : MonoBehaviour {



	// Use this for initialization
	void Start () {


	}

	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter(Collider other) {

		Physics.IgnoreLayerCollision(LayerMask.NameToLayer("Map"),                             
			LayerMask.NameToLayer("Map"), false);

		PlayerHP.HP = PlayerHP.HP - 1;

		print ("HP : " + PlayerHP.HP);

		GameObject.Find("TakingDamage").GetComponent<AudioSource> ().Play ();
		}


}
