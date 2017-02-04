using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

//using Fungus;

public class option : MonoBehaviour {

	public static option current;


	public GameObject popUp,boxSetting; 
	public static bool muncul = false;
	public int scene;
	public string sceneToSkip;
	int playing;
	bool set;

	//public static string GetString(string key, string defaultValue = ""); 
	//public static List<option> savedGames = new List<option>();

	//public Flowchart; 

	// Use this for initialization
	void Start () {
		PlayerPrefs.GetInt ("playing");
		playing = PlayerPrefs.GetInt ("playing");
		//Time.timeScale = 1;
		popUp.SetActive (false);
		boxSetting.SetActive (false);
		//scene = PlayerPrefs.GetString ("Scene Name");


	
	}
	
	// Update is called once per frame
	void Update () {

	}

	public void popUpSetting(){

		if(muncul == false ){
			Time.timeScale = 0;
			popUp.SetActive (true);
			muncul = true;
		}else if (muncul == true){
			popUp.SetActive (false);
			muncul = false;
			Time.timeScale = 1;
		}
	}

	public void closePop(){
		popUp.SetActive (false);
		muncul = false;
	}

	public void returnScene(){
		muncul = true;
		popUp.SetActive (false);
		Time.timeScale = 1;
	}
	

	public void skipScene(){
		if (playing == 1) {
			if (scene == 1) {
				Application.LoadLevel (sceneToSkip);
				Time.timeScale = 1;
			}
		} else if (playing == 0) {
			Debug.Log ("it's your first time");
		}
	}



	public void setting(){
		boxSetting.SetActive (true);
		set = true;
	

	}

	public void backSetting(){
		boxSetting.SetActive (false);
	}

	public void mainMenu(){
		PlayerPrefs.SetString("lastLevel", Application.loadedLevelName);
		menuAwal.newGame = true;
		Application.LoadLevel ("menuAwal");
		menuAwal.textCont = false;
	}



	



}
