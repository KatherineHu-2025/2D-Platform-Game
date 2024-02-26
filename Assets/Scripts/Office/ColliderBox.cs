using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColliderBox : MonoBehaviour
{   
    private Rigidbody2D _boxRigidbody;
    public Slider moneySlider;
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
            moneySlider.value = money;
        }
    }
}
