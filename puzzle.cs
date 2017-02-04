using UnityEngine;
using System.Collections;

public class puzzle : MonoBehaviour {

	public GameObject puzzle1,puzzle2, puzzle3, puzzle4, puzzle5, puzzle6, puzzle7, puzzle8, puzzle9;
	public GameObject popUpSoal;

	void Start(){
		popUpSoal.SetActive (false);
	}

	public void munculSoal(){
		//soal muncul ketika salah satu puzzle dipilih
		popUpSoal.SetActive (true);
	
	}

	public void jawabBenar(){
		popUpSoal.SetActive (false);
	}

}
