using UnityEngine;
using System.Collections;

public class artifact : MonoBehaviour {

	public GameObject popUpArt,art,page1,page2,warning,motionpedia;
	public static bool muncul = false,artifactOK = false;
	public bool Updateart;
	int playing;


	// Use this for initialization
	void Start () {
		PlayerPrefs.GetInt ("playing");
		playing = PlayerPrefs.GetInt ("playing");
		Time.timeScale = 1;
		popUpArt.SetActive (false);
		//warning.SetActive (false);
		//art.SetActive (false);
		motionpedia.SetActive (false);
		//updaeteArt ();

	
	}
	

	// Update is called once per frame
	void Update () {

	}

	public  void popUpSetting(){
		
		if(muncul == false ){
			Time.timeScale = 0;
			popUpArt.SetActive (true);
			motionpedia.SetActive (false);
			muncul = true;
		}else if (muncul == true){
			popUpArt.SetActive (false);
			muncul = false;
			Time.timeScale = 1;
		}
	}
	public void closePop(){
		popUpArt.SetActive (false);
		muncul = false;
	}
	public void updaeteArt(){ //update artifact yg udah didapat nusa
		//art.SetActive (true);
		artifactOK = true;
		Debug.Log ("executed update");
	}

	public void warningPop(){
		//warning.SetActive (true);
		Debug.Log ("executed warning");
	}

	public void warningPopFalse(){
		//warning.SetActive (false);
	}

	public void navPageRight(){ //navigasi page artifact

		page1.SetActive (true);
		page2.SetActive (false);

	}

	public void navPageLeft(){ //navigasi page artifact
		
		page1.SetActive (false);
		page2.SetActive (true);
		
	}

	public void Motionpedia(){
		if(artifactOK == true){
			motionpedia.SetActive (true);
		}
	}

	public void backMP(){
		motionpedia.SetActive (false);
		popUpArt.SetActive (true);	
		}






}

