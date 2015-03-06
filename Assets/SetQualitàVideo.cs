using UnityEngine;
using System.Collections;

public class SetQualitàVideo : MonoBehaviour {

	private float NumberOfStep;
	// Use this for initialization
	void Start () {

	
	}
	
	// Update is called once per frame
	void Update () {

	//NumberOfStep =

	}

	public void SetFanta() 
	{
		QualitySettings.SetQualityLevel ( 5 );
	}
	public void SetBeauti() 
	{
		QualitySettings.SetQualityLevel ( 4 );
	}
	public void SetGood() 
	{
		QualitySettings.SetQualityLevel ( 3 );
	}
	public void SetSimple() 
	{
		QualitySettings.SetQualityLevel ( 2 );
	}
	public void SetFaster() 
	{
		QualitySettings.SetQualityLevel ( 1 );
	}
	/*public void Lumino()
	{
		if (NumberOfStep == 1 )
		{
			RenderSettings.ambientLight;
		}
	}*/
}
