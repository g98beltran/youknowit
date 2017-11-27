using UnityEngine;
using System.Collections;
using UnityEngine.UI;//Api per a user interface
using UnityEngine.EventSystems;

public class ClickAction : MonoBehaviour, IPointerClickHandler{

	public void OnPointerClick(PointerEventData eventData){
		Debug.Log("Click");
	}
}