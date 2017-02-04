using UnityEngine;
using System.Collections;
using LitJson;
using UnityEngine.UI;

public class Soal : MonoBehaviour {

	public string filePath;
	public string jsonString;
	public JsonData soalData;
	public int numberSoal=1;
	public GameObject jawabanPrefab;
	public GameObject soal;


	
	
	
	public void SoalBegin(){
		Debug.Log ("read file");
		//filePath = System.IO.Path.Combine(Application.streamingAssetsPath,jsonName+ ".json");
		filePath = "jar:file://" + Application.dataPath + "!/assets/StreamingAssets/soal.json";
		StartCoroutine ("Json");
		//soalData = JsonMapper.ToObject (jsonString);
	}
	
	IEnumerator Json(){
		/*
		if (filePath.Contains ("://")) {
			WWW www = new WWW (filePath);
			yield return www;
			jsonString = www.text;
			//jsonString = System.IO.File.ReadAllText(filePath);
		} else {
			jsonString = System.IO.File.ReadAllText(filePath);
		}soalData = JsonMapper.ToObject (jsonString);
		//OnClick();

*/
		WWW www = new WWW (filePath);
		yield return www;
		//jsonString = www.text;
		jsonString = Resources.Load<TextAsset> ("soal").text;
		soalData = JsonMapper.ToObject (jsonString);
		
	}
	
	public void OnClick(){

		Debug.Log ("clicked");
		
		SoalBegin ();
		//SoalBegin ("soal.json");
		

		GameObject[] jawabanDestroy = GameObject.FindGameObjectsWithTag ("Jawaban");
		if (jawabanDestroy != null) {
			for (int x=0; x<jawabanDestroy.Length; x++) {
				DestroyImmediate (jawabanDestroy [x]);
			}
		}



			GameObject.Find ("soal/Panel/SoalC/Soal/Text").GetComponentInChildren<Text> ().text = soalData ["data"] [numberSoal] ["soal"].ToString ();

			for (int i=0; i<soalData["data"][numberSoal]["jawaban"].Count; i++) {
			
				GameObject jawaban = Instantiate (jawabanPrefab);
				jawaban.GetComponentInChildren<Text> ().text = soalData ["data"] [numberSoal] ["jawaban"] [i].ToString ();
				Transform jawabanC = GameObject.Find ("JawabanC").GetComponent<Transform> ();
				jawaban.transform.SetParent (jawabanC);
				if (i == 0) {
				 

					jawaban.GetComponent<Button> ().onClick.AddListener (() => Jawaban (1));
					//jawaban.GetComponent<Button> (). onClick.AddListener (() => Jawaban (1));
				} else {
					jawaban.GetComponent<Button> ().onClick.AddListener (() => Jawaban (0));
				}
				jawaban.transform.SetSiblingIndex (Random.Range (0, 3));
			}


			numberSoal++;

	}


	public void Jawaban(int y){
		if (y == 1) {
			Debug.Log("Jawaban Benar"); //kalo jawaban benar
			//aktifSoal.soal.SetActive (false);
			OnClick();
			soal.SetActive (false);




		}else{
			Debug.Log("Jawaban Salahh"); //kalo jawaban salah
			//soal yg salah di munculin lagi random
			OnClick();
		}
		
	}


}
