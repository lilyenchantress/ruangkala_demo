using UnityEngine;
using System.Collections;

public class aktifSoal : MonoBehaviour {
	public GameObject soal;
	public static bool puzzleEnable; //buat ngecek ada puzzle yg aktif atau nggak, nilainya ntar diambil sm class boxPuzzle supaya puzzle yg lain gbs di klik klo ada yg aktif
	// Use this for initialization
	void Start () {
		soal.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void soalMuncul(){
		if (puzzleEnable == false) {
			soal.SetActive (true);
			puzzleEnable = true;
		} 
	}
}
