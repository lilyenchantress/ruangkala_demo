using UnityEngine;
using System.Collections;
using UnityEngine.UI;
//using Fungus;

public class menuAwal : MonoBehaviour {

	public GameObject menu,contText, cont, chapterSel, setting, more, hint, motionpedia, exit,logo,popUpConfig,popUpartifact;
	public bool newItem;
	static int playing;
	public static bool newGame=false;
	public static bool textCont=true;




	// Use this for initialization
	void Start () {
		//newGame = true;
		PlayerPrefs.GetInt ("playing");
		playing = PlayerPrefs.GetInt ("playing");
			Debug.Log ("new game " + newGame);
		Debug.Log (playing);
		if (playing == 0) {
			if (newGame == false) {
				cont.SetActive (false);
			}else if(newGame == true ){
				contText.SetActive (false);
				cont.SetActive (true);
				menu.SetActive (true);
			} else if(newGame == false){
				cont.SetActive (false);
			}

		} else if (playing == 1){
			if (newGame == false) {
				cont.SetActive (true);
			}else if(newGame == true ){
				contText.SetActive (false);
				cont.SetActive (true);
				menu.SetActive (true);
			} else if(newGame == false){
				cont.SetActive (false);
			}
		}

	

	

		if (textCont == true){
			contText.SetActive (true);
			textCont = false;
		}else if (textCont == false && newGame == false){
			contText.SetActive (false);
			menu.SetActive (true);
		}


		chapterSel.SetActive (false);
		setting.SetActive (false);
		more.SetActive (false);
		hint.SetActive (false);
		motionpedia.SetActive (false);
		exit.SetActive (false);
		popUpConfig.SetActive (false);
		popUpartifact.SetActive (false);








	}
	
	// Update is called once per frame
	void Update () {
		newGame = true;

	
	}

	public void newgamesPop(){
		PlayerPrefs.DeleteAll ();
		newGame = true;
		Debug.Log ("new game " + newGame);
		textCont = false;
	

	}

	public void chapterselectPop(){
		logo.SetActive (false);
		chapterSel.SetActive (true);
	}

	public void settingPop(){
		logo.SetActive (false);
		setting.SetActive (true);
	}

	public void morePop(){
		logo.SetActive (false);
		more.SetActive (true);
	}

	public void hintPop(){
		logo.SetActive (false);
		hint.SetActive (true);
	}

	public void motionpediaPop(){
		logo.SetActive (false);
		motionpedia.SetActive (true);
	}

	public void exitPop(){
		logo.SetActive (false);
		exit.SetActive (true);
	}

	public void cancelExit(){
		logo.SetActive (true);
		exit.SetActive (false);
	}

	public void yesExit(){
		//PlayerPrefs.SetString("lastLevel", Application.loadedLevelName);
		PlayerPrefs.SetInt ("playing",1);
		newGame = true;
		PlayerPrefs.Save ();
		Application.Quit();

		Debug.Log ("apps exit");

	}

	public void popConfig(){
		popUpConfig.SetActive (true);
	}

	public void popArtifact(){
		popUpartifact.SetActive (true);
	}

	public void backMenuchapter(){
		logo.SetActive (true);
		chapterSel.SetActive (false);
	}

	public void backMenuSetting(){
		logo.SetActive (true);
		setting.SetActive (false);
	}

	public void backMenuHint(){
		logo.SetActive (true);
		hint.SetActive (false);
	}

	public void backMenuMotionpedia(){
		logo.SetActive (true);
		motionpedia.SetActive (false);
	}

	public void backHome(){
		menu.SetActive (true);
		logo.SetActive (true);
		popUpConfig.SetActive (false);
		Debug.Log ("backMenu");
	}

	public void continueMenu(){
		menuAwal.newGame = false;
		menu.SetActive (true);
		contText.SetActive (false);

	}

	public void continueGame(){
		//option.Load ();
		Application.LoadLevel(PlayerPrefs.GetString("lastLevel"));
	}
}
