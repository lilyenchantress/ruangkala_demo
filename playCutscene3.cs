﻿using UnityEngine;
using System.Collections;

public class playCutscene3 : MonoBehaviour {
	int playing;
	// Use this for initialization
	void Start () {
		PlayerPrefs.SetString("lastLevel", Application.loadedLevelName);
		PlayerPrefs.GetInt ("playing");
		playing = PlayerPrefs.GetInt ("playing");
		if (playing == 0) {
			Handheld.PlayFullScreenMovie ("Cutscene - ENDING [draft](1)_x264.mp4", Color.black, FullScreenMovieControlMode.Hidden);
			Application.LoadLevel ("bersambungAfterCredit");
		} else if (playing == 1){
			Handheld.PlayFullScreenMovie ("Cutscene - ENDING [draft](1)_x264.mp4", Color.black, FullScreenMovieControlMode.CancelOnInput);
			Application.LoadLevel ("bersambungAfterCredit");
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
