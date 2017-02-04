
using UnityEngine;
using System.Collections;

public class enable_dummy : MonoBehaviour {

	public GameObject button_ , obj;

	// Use this for initialization
	void Start () {

		obj.SetActive (true);
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void enableObj(){
		button_.SetActive (false);
	}
}
