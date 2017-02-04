using UnityEngine;
using System.Collections;
using Fungus;

public class closePetunjuk : MonoBehaviour {

	public GameObject petunjuk;
//	Fungus.SetLanguage();

	// Use this for initialization
	void Start () {

	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void close(){
		petunjuk.SetActive (false);
		Time.timeScale = 1;
	}
}
