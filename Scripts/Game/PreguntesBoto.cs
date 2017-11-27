using UnityEngine;
using System.Collections;
using UnityEngine.UI;//Api per a user interface
using UnityEngine.EventSystems;

public class PreguntesBoto : MonoBehaviour, IPointerClickHandler{

	//variables
	public Text text;
	string[] preguntes = new string[5] {"e","f","g","y","e"};
	int a = 0;

	public void OnPointerClick(PointerEventData eventData){
		//quan s'hapreta el boto
		text.text = preguntes[a];
		if(a<5){a = a + 1;}
	}
}