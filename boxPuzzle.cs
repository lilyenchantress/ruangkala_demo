using UnityEngine;
using System.Collections;
using UnityEngine.Audio;

public class boxPuzzle : MonoBehaviour {

	public GameObject slot,boxAktif,puzlleAktif,puzzleSlot,backBox,related,warningCek;
	public int boxId;
	bool benar,visited;
	static int jmlBenar=0,step;
	AudioSource salah;
	int time=0;

	Vector3 targetPosition,currentPos;

	// Use this for initialization
	void Start () {
		AudioSource[] audio = GetComponents<AudioSource>();
		salah = audio [1];
		Debug.Log (puzlleAktif.transform.position.x);
		Debug.Log (puzlleAktif.transform.position.y);
		warningCek.SetActive (false);


	}
	
	// Update is called once per frame
	void Update () {
	
	}



	public void playSalah (){
		salah.Play ();
	}

	public void boxPuzzlee(){
		//Move = new move ();
		//enablePuzzle ();
		//puzlleAktif = GetComponents(GameObject.FindGameObjectsWithTag("puzzle"));

		puzlleAktif = move.puzlleAktif ;
		Debug.Log ("puzzle aktif = " + puzlleAktif );
		Debug.Log (puzlleAktif.transform.position.x);
		Debug.Log (puzlleAktif.transform.position.y);
		boxAktif = slot;
		Debug.Log ("box aktif " + boxAktif);
		puzzleSlot = puzlleAktif;
		//cekPuzzle ();
		targetPosition.x = boxAktif.transform.position.x;
		targetPosition.y = boxAktif.transform.position.y;
		puzzleSlot.transform.position = targetPosition;
		step++;
		aktifSoal.puzzleEnable = false;
		//cekPuzzle ();

		//puzlleAktif = null;
		//bool isKlik = true;




	}

	public void undoPuzzle(){

		puzzleSlot = move.puzlleAktif;
		move.temp.SetActive (true);
		puzzleSlot.SetActive (false);
		Debug.Log ("puzzle aktif = " + puzlleAktif );
		Debug.Log ("trigger: " + move.temp);	
		//puzzleSlot = puzlleAktif;
		currentPos.x = backBox.transform.position.x;
		currentPos.y = backBox.transform.position.y;
		puzzleSlot.transform.position = currentPos;
		step--;
		aktifSoal.puzzleEnable = false;


	}

	public void cekPuzzle(){
		if (puzzleSlot == related && visited == false) {
			benar = true;
			visited = true;
			Debug.Log ("box:  " + boxAktif + "puzzle: " + puzzleSlot + "related: " + related);
			Debug.Log ("benar");
			jmlBenar ++;
			Debug.Log ("jml benar: " + jmlBenar);
		} else  if (puzzleSlot == related && visited == true) {
			benar = true;
			Debug.Log ("box:  " + boxAktif + "puzzle: " + puzzleSlot + "related: " + related);
			Debug.Log ("benar");
			Debug.Log ("jml benar: " + jmlBenar);

		} else {
			Debug.Log ("salah");
		}


	}

	public void cekAll(){

		if (jmlBenar == 9) {
			Application.LoadLevel ("scene1_RuangkalaAtas2");
		} else if (jmlBenar <= 8 ){
			jmlBenar = 0;
			playSalah ();
			Application.LoadLevel(Application.loadedLevel);
			}
		jmlBenar = 0;
		           
	}

	public void warningCekmuncul(){
		warningCek.SetActive (true);
	}

	public void warningCekNo(){
		warningCek.SetActive (false);
	}

}
