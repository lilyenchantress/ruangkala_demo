using UnityEngine;
using System.Collections;

public class pertanyaan : MonoBehaviour {

	public GameObject soal, nextSoal;
	// Use this for initialization
	void Start () {
		soal.SetActive (true);
		nextSoal.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	


	
	public void jawabanSalah (){
		soal.SetActive (false);
		nextSoal.SetActive (true);
	}
}
