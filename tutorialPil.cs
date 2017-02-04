using UnityEngine;
using System.Collections;

public class tutorialPil : MonoBehaviour {
	
	public GameObject tutorial;
	int playing;
	
	// Use this for initialization
	void Start () {
		PlayerPrefs.GetInt ("playing");
		playing = PlayerPrefs.GetInt ("playing");
		munculTutorial();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	public void munculTutorial(){
		if (playing == 0) {

			tutorial.SetActive (true);
			
		}
		
	}
}
