using UnityEngine;
using System.Collections;
using UnityEngine.Audio;

public class buttonMusic : MonoBehaviour {

	 AudioSource suara, universal, warning, petunjuk ;

	// Use this for initialization
	void Start () {
		AudioSource[] audio = GetComponents<AudioSource>();
		suara = audio[0];
		petunjuk = audio [1];
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void playSuara(){
		Debug.Log ("suara play");
		suara.Play ();
		Debug.Log ("suara play");
	}

	public void playPetunjuk(){
		petunjuk.Play ();
		Debug.Log ("suara play");
	}
}
