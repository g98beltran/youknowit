using UnityEngine;
using System.Collections;
using UnityEngine.UI;

//Script per a el text de pantalla1
public class Pregunta : MonoBehaviour{

	Text text;
	public Button boto;
	string[] preguntes;
	int a=0;

	// Use this for initialization
	void Start () {
		for(int i=0; i< 10;i++){
			preguntes[i] = "Pregunta "+i+".";
		}
		text = GetComponent <Text> ();
		Button btn = boto.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);  
	}
		
	void TaskOnClick(){
		text.text = preguntes[a];
		a++;
	}
}
