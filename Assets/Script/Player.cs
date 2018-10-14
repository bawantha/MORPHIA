using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    private float inputDirection;
    private CharacterController character;
    private Vector3 moveVector;
    private float speed = 5.0f;
    private float verticalVelocoty;
    private float gravity = 1.0f;


	// Use this for initialization
	void Start () {
        character = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {
       inputDirection=  Input.GetAxis("Horizontal")*speed;
        if (character.isGrounded)
        {
            verticalVelocoty = 0;
        }
        else
        {
            verticalVelocoty -= gravity;
        }
        moveVector = new Vector3(inputDirection, verticalVelocoty , 0);
        character.Move(moveVector*Time.deltaTime);

	}
}
