using UnityEngine;
using System.Collections;

public class soalPuzzle : MonoBehaviour {

	public GameObject panelSoal;

	// Use this for initialization
	void Start () {
	
		panelSoal.SetActive (false);
	

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public  void soalMuncul(){

		panelSoal.SetActive (true);
	}

	public void jawabanBenar(){
		//yield return new WaitForSeconds (2f);
	panelSoal.SetActive (false);
		
		
	}

}
