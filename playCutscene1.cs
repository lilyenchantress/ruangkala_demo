using UnityEngine;
using System.Collections;

public class playCutscene1 : MonoBehaviour {
	int playing;
	// Use this for initialization
	void Start () {
		PlayerPrefs.SetString("lastLevel", Application.loadedLevelName);
		PlayerPrefs.GetInt ("playing");
		playing = PlayerPrefs.GetInt ("playing");
		if (playing == 0) {
			Handheld.PlayFullScreenMovie ("Cutscene - opening 24fps_x264.mp4", Color.black, FullScreenMovieControlMode.Hidden);
			Application.LoadLevel ("scene1_RuangMisterius");
		} else if (playing == 1) {
			Handheld.PlayFullScreenMovie ("Cutscene - opening 24fps_x264.mp4", Color.black, FullScreenMovieControlMode.CancelOnInput);
			Application.LoadLevel ("scene1_RuangMisterius");
		}

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
