using UnityEngine;
using System.Collections;

public class move : MonoBehaviour {

	public GameObject trigger;
	public GameObject puzzle1,puzzle2,puzzle3,puzzle4,puzzle5,puzzle6,puzzle7,puzzle8,puzzle9,puzzle;
	public static GameObject puzlleAktif,boxAktif;

	Vector3 targetPosition,koordinat;
	//bool isActive = true, puzzleAktif ;
	public static GameObject temp,tempPuzzle;



	void Start () {

		puzzle1.SetActive (false);
		puzzle2.SetActive (false);
		puzzle3.SetActive (false);
		puzzle4.SetActive (false);
		puzzle5.SetActive (false);
		puzzle6.SetActive (false);
		puzzle7.SetActive (false);
		puzzle8.SetActive (false);
		puzzle9.SetActive (false);


		//trigger.SetActive (false);




		targetPosition = transform.position; //simpan posisi

		Debug.Log (globalTrigger.isActive );
		Debug.Log (globalTrigger.puzzleAktif );



	}
	public void enablePuzzle(){
		if (aktifSoal.puzzleEnable == false) {
			puzzle.SetActive (true);
			Debug.Log ("puzzle enable " + aktifSoal.puzzleEnable);
			Debug.Log ("trigger : " + trigger);
			//isActive = true;

			puzlleAktif = puzzle;
			//puzzleAktif = true;
			Debug.Log ("puzzle aktif = " + puzlleAktif);

			trigger.SetActive (false);
			temp = trigger;
		} else {
			Debug.Log ("ada puzzle yg aktif");
		} 

	}

	/*
	public void cek(){
		Debug.Log ("cekpuzzle"+globalTrigger.puzzleAktif);
		//return puzlleAktif;
		if (globalTrigger.isActive == true && globalTrigger.puzzleAktif == true ) {
			Debug.Log ("if");
			Debug.Log ("temp"+trigger);
			puzzle.SetActive (true);
			trigger.SetActive (false);
			temp.SetActive (true);
			tempPuzzle.SetActive (false);
			Debug.Log ("puzzle aktif" + globalTrigger.puzzleAktif);
			
		}
		if (globalTrigger.isActive == true && globalTrigger.puzzleAktif == false) {
			Debug.Log ("else");
			puzzle.SetActive (true);
			Debug.Log ("trigger : " + trigger);
			globalTrigger.isActive = true;


			puzlleAktif = puzzle;
			globalTrigger.puzzleAktif = true;
			Debug.Log ("puzzle aktif = " + puzlleAktif);
			trigger.SetActive (false);
			temp = trigger;
			tempPuzzle = puzlleAktif;
			//isActive = false;
			Debug.Log ("temp"+trigger);

		}
		Debug.Log ("isActive"+globalTrigger.isActive);
	}

*/

	//fungsi set target
	/*
	public void boxPuzzle(){
		//enablePuzzle ();
		//puzlleAktif = GetComponents(GameObject.FindGameObjectsWithTag("puzzle"));

		Debug.Log ("puzzle aktif = " + puzlleAktif );
		boxAktif = slot;
		Debug.Log ("box aktif " + boxAktif);

		targetPosition.x = boxAktif.transform.position.x;
		targetPosition.y = boxAktif.transform.position.y;
		puzlleAktif.transform.position = targetPosition;
		 //bool isKlik = true;
	}
*/


	//fungsi setactive gameobject






}
