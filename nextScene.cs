using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class nextScene : MonoBehaviour {
	Texture2D blackTexture; //texture overlay
	float fadeSpeed = 5.0f;		//kecepatan fading
	float alpha = 1.0f;		//alpha texture antara 0-1
	float DelayTime = 3;
	
	public string WhatScene;
	public static nextScene current;
	public static List<nextScene> savedGames = new List<nextScene>();
	// Use this for initialization
	void Start () {
		alpha = 1.0f;
		blackTexture = new Texture2D (1, 1);
		blackTexture.SetPixel (0, 0, Color.black);
		blackTexture.Apply ();
	}
	
	public void LoadingScene(){
		Application.LoadLevel(WhatScene);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnGUI(){
		if ( alpha > -1){
			alpha -= fadeSpeed * Time.deltaTime;
			
			//Color temp = GUI.color;
			//temp.a = alpha;
			//GUI.color = temp; 
			GUI.DrawTexture(new Rect(0,0,Screen.width, Screen.height),blackTexture);
		} else {
			Invoke("LoadingScene",DelayTime);
		}
		
	}



}
