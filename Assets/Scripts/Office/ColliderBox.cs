using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderBox : MonoBehaviour
{   
    private Rigidbody2D _boxRigidbody;
    private float money;
    void Start(){
        _boxRigidbody = GetComponent<Rigidbody2D>();
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        // If the Collider2D component is enabled on the collided object
        if (coll.collider == true)
        {
            // Disables the Collider2D component
            float money = coll.gameObject.GetComponent<Character>().IncreaseMoney();
            Debug.Log("Money Added: " + money);
        }
    }
}
