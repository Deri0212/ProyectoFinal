using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NextTextScript : MonoBehaviour
{
    public List<GameObject> texts;
    public GameObject nextDialogue;
    public GameObject actualDialogue;
    public int currentText;
    public void nextText(){
        if(currentText==texts.Count-1){
            actualDialogue.SetActive(false);
            nextDialogue.SetActive(true);
        }
        else{
            texts[currentText].SetActive(false);
            texts[currentText+1].SetActive(true);
            currentText++;
        }
        
    }
}
