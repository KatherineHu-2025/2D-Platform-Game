using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Exit : MonoBehaviour
{
    public Transform raycastOrigin; 
    public float raycastDistance = 3f;
    public LayerMask layerMask;
    public TMP_Text myText;


    void Update()
    {
        shootRaycast();
    }

    void shootRaycast(){
        RaycastHit2D hit = Physics2D.Raycast(raycastOrigin.position, Vector2.up, raycastDistance, layerMask);
        if (hit.collider != null)
        {   
            if(hit.collider.gameObject.GetComponent<Character>().money >= 100){
                myText.text = "Good job! Now you can go home.";
            }
            else{
                myText.text = "Alright, well done you! How are you gonna feed yourself?";
            }
            Application.Quit();
            UnityEditor.EditorApplication.isPlaying = false;
        }
    }

    void OnDrawGizmos()
    {
        if (raycastOrigin != null)
        {
            Gizmos.color = Color.red;
            Gizmos.DrawLine(raycastOrigin.position, raycastOrigin.position + Vector3.up * raycastDistance);
        }
    }
}
