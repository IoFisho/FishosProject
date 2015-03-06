using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class RisoluzioneSet : MonoBehaviour {


	public bool FS ;
	private string[] stringaRisoluzioni;
	public Slider qSlider;
	public Slider sdSlider;
	public Slider masterAudioSlider;
	public Text qLabel;

	// Use this for initialization
	void Start () {

		Resolution[] resolutions = Screen.resolutions;
		foreach (Resolution res in resolutions) 
		{
			print(res.width + "x" + res.height);//
		}

		qSlider.maxValue = QualitySettings.names.Length-1;
		qSlider.value = QualitySettings.GetQualityLevel ();


		sdSlider.onValueChanged.AddListener((value) => { QualitySettings.shadowDistance = value; });
		masterAudioSlider.onValueChanged.AddListener((value) => { AudioListener.volume = value; });

	}





	// Update is called once per frame
	void Update () {

	}
	
	public void SetQuality (float qs) 
	{
		int qsi = Mathf.RoundToInt (qs);
		QualitySettings.SetQualityLevel (qsi);
		qLabel.text = QualitySettings.names [qsi];
		sdSlider.value = QualitySettings.shadowDistance;
	}
	
	public void SetShadowDistance (float dist)
	{
		QualitySettings.shadowDistance = dist; 
	}

	public void SetRosoluzione640 ()
	{
		Screen.SetResolution ( 640, 480, FS );
	}

	public void SetFS ()
	{
		FS = true;
	}
	public void SetNoFS ()
	{
		FS = false;
	}
	public void SetRosoluzione800 ()
	{
		Screen.SetResolution ( 800, 600, FS );
	}
	public void SetRosoluzione1024 ()
	{
		Screen.SetResolution ( 1024, 768, FS );
	}
	public void SetRosoluzione1280 ()
	{
		Screen.SetResolution ( 1280, 720, FS );
	}
	public void SetRosoluzione1920 ()
	{
		Screen.SetResolution ( 1920, 1080, FS );
	}

	public void SettaRisolSlider (float NumeroRisoluzione)
	
	{
		if (NumeroRisoluzione == 1)
		{

		}
		if (NumeroRisoluzione == 2)
		{
			
		}
		if (NumeroRisoluzione == 3)
		{
			
		}


	}
}
