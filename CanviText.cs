using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CanviText : MonoBehaviour{
    
	Text text;


    void Awake ()
    {
        text = GetComponent <Text> ();
        
    }


    void Update ()
    {
        if(PlayerPrefs.HasKey("")){
        	string score = PlayerPrefs.GetString("");
        	text.text = "Your score is: \n"+score;
        }else{text.text = "Error in DataBase";}
        
    }
}
