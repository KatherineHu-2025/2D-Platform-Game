using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class YesButton : MonoBehaviour
{
    public TMP_Text myText;

    public void Pressed(){
        StartCoroutine(Press());
    }
    IEnumerator Press(){
        myText.text = "As you wished.";
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene("Main Menu");
    }

}
