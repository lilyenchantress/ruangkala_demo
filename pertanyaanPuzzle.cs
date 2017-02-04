using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class pertanyaanPuzzle : MonoBehaviour {

	public GameObject main_soal,soal_;
	public static int first=0;



	// Use this for initialization
	void Start () {
	
		main_soal.SetActive (true);
		soal_.SetActive (true);
		Debug.Log ("soal aktif: " + soal_);
		AudioSource[] audio = GetComponents<AudioSource>();


	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	public void jawabanBenar(){
		//benar.colors.
	
		soal_.SetActive (false);
		main_soal.SetActive (false);

		first=1;

	}

	public void jawabanSalah(){

		soal_.SetActive (false);

	}


}
