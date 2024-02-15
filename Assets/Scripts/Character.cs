using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    private SpriteRenderer _playerSpriteRenderer;
    private Rigidbody2D _playerRigidBody;
    private Animator _playerAnimator;
    public float speed;
    private bool s_movement;

    // Start is called before the first frame update
    void Start()
    {
        _playerSpriteRenderer = GetComponent<SpriteRenderer>();
        _playerRigidBody = GetComponent<Rigidbody2D>();
        _playerAnimator = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        playerMovement();
    }

    void playerMovement(){
        Vector3 velocity = new Vector3(0.0f,0.0f,0.0f);

        if (Input.GetKey(KeyCode.D))
        {   
            velocity += Vector3.right;
            _playerAnimator.SetTrigger("isMoving");
        }

        if (Input.GetKey(KeyCode.A))
        {
            velocity += Vector3.left;
            _playerAnimator.SetTrigger("isMoving");
        }

        _playerRigidBody.velocity = velocity * Time.deltaTime * speed;
    }
}
