using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartScene : MonoBehaviour
{
    private void Update()
    {


    }



    private void OnTriggerEnter2D(Collider2D collision)
    {   
        if(collision.CompareTag("Player")){
            Debug.Log("collision entered");
            SceneManager.LoadScene("BoyPhase");
        }
    }
}
