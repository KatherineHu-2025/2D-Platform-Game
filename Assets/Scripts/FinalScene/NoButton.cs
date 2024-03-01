using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class NoButton : MonoBehaviour
{
    public TMP_Text myText;

    public void Pressed(){
        StartCoroutine(Press());
    }
    IEnumerator Press(){
        myText.text = "There is no mistakes in life.";
        yield return new WaitForSeconds(1.5f);
        Application.Quit();
        UnityEditor.EditorApplication.isPlaying = false;
    }
}
