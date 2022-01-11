using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGM : MonoBehaviour {

	// Use this for initialization
	private static int COUNT = 0;

	private int index = 0;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Application.loadedLevelName == "DemoScene")
			GameObject.Destroy (this.gameObject);

	}

	void Awake()

	{

		index = COUNT;

		COUNT++;

		print ("LifeCycle Awake " + index);



		if (index == 0)

			DontDestroyOnLoad(gameObject);

		else

			Destroy(gameObject);

	}
}
