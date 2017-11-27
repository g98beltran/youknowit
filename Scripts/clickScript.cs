using UnityEngine;
using System.Collections;
using UnityEngine.UI;//Api per a user interface

public class clickScript : MonoBehaviour {

	public Button boto;
	// Use this for initialization
	void Start () {
		Button btn = boto.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
	}
	
	// Coses que fa quan el boto s'apreta
	void TaskOnClick () {
		Debug.Log("Click");
	}
}
