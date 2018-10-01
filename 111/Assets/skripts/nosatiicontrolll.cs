using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nosatiicontrolll : MonoBehaviour {
    public float speed = 20f;
    private Rigidbody2D nos;

    public GameObject bonus;

	void Start () {
        nos = GetComponent<Rigidbody2D>();
		
	}
	
	void Update () {
        float moveX = Input.GetAxis("Horizontal");
        nos.MovePosition(nos.position + Vector2.right * moveX * speed * Time.deltaTime);
        if (Input.GetKeyDown(KeyCode.Space))
        nos.AddForce(Vector2.up * 8000);

    }
} 
