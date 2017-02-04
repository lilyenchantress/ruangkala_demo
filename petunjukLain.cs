using UnityEngine;
using System.Collections;

public class petunjukLain : MonoBehaviour {

	public GameObject petunjuknya;
	int playing;

	// Use this for initialization
	void Start () {
		PlayerPrefs.GetInt ("playing");
		playing = PlayerPrefs.GetInt ("playing");
		Time.timeScale = 0;
		munculPetunjuk ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void munculPetunjuk(){
		if (playing == 0) {
			Time.timeScale = 0;
			petunjuknya.SetActive (true);

		}

	}
}
