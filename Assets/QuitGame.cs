﻿using UnityEngine;
using System.Collections;

public class QuitGame : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public	void ChiudiTutto() {
	
		if(!Application.isEditor) Application.Quit();
	}
}
