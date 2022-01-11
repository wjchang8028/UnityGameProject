using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToMAIN : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void ChangeGameScene()
	{
		SceneManager.LoadScene("DD2");
	}
}
