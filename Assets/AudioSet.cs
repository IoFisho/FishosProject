using UnityEngine;
using System.Collections;

public class AudioSet : MonoBehaviour {

	public GameObject Aduiooo;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown(KeyCode.Q))
		{
			Aduiooo.SetActive (true);
		}
		if (Input.GetKeyDown(KeyCode.W))
		{
			Aduiooo.SetActive (false);
		}
			
	}

	public void AudioBitch (float Bau)
	{

		AudioListener.volume = Bau;
	}

}
