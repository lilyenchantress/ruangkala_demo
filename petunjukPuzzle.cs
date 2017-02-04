using UnityEngine;
using System.Collections;

public class petunjukPuzzle : MonoBehaviour {

	public GameObject petunjuk,p2,p3,p4,p5;
	public static int first;
	int playingPuzzle;
	// Use this for initialization
	void Start () {
		Debug.Log (playingPuzzle);

		PlayerPrefs.GetInt ("playingPuzzle");
		playingPuzzle = PlayerPrefs.GetInt ("playingPuzzle");

		if(first == 0){
			petunjuk.SetActive (true);
			p2.SetActive (true);
			p3.SetActive (true);
			p4.SetActive (true);
			p5.SetActive (true);
		}
		first=1;

		if( playingPuzzle == 0){
			petunjuk.SetActive (true);
			p2.SetActive (true);
			p3.SetActive (true);
			p4.SetActive (true);
			p5.SetActive (true);
		}
		PlayerPrefs.SetInt ("playingPuzzle",1);
		Debug.Log ("puzzle 1");
		//Debug.Log (playingPuzzle);
		PlayerPrefs.Save ();

	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void infoPuzzle(){
		petunjuk.SetActive (true);
		p2.SetActive (true);
		p3.SetActive (true);
		p4.SetActive (true);
		p5.SetActive (true);
	}



}
