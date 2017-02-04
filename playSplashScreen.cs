using UnityEngine;
using System.Collections;

public class playSplashScreen : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Handheld.PlayFullScreenMovie ("Motiontale Logo_x264_001.mp4", Color.black, FullScreenMovieControlMode.Hidden);
		Application.LoadLevel ("menuAwal");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
