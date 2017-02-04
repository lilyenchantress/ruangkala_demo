using UnityEngine;
using System.Collections;

public class playCredit : MonoBehaviour {
	int playing;
	// Use this for initialization
	void Start () {
		PlayerPrefs.SetString("lastLevel", "menuAwal");
		PlayerPrefs.GetInt ("playing");
		playing = PlayerPrefs.GetInt ("playing");
		if (playing == 0) {
			Handheld.PlayFullScreenMovie ("Ruangkala CREDITS Demo_x264.mp4", Color.black, FullScreenMovieControlMode.Hidden);
			Application.LoadLevel ("openlink");
		} else if (playing == 1){
			Handheld.PlayFullScreenMovie ("Ruangkala CREDITS Demo_x264.mp4", Color.black, FullScreenMovieControlMode.CancelOnInput);
			Application.LoadLevel ("openlink");
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
