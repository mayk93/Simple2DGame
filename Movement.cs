﻿using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

	public Vector3 velocity = Vector3.zero;
	public Vector3 gravity;
	public Vector3 flapVelocity;

	public float maxSpeed = 1f;

	bool hasFlapped = false;

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if( Input.GetMouseButton(0) )
		{
			hasFlapped = true;
		}

		maxSpeed = 2 - transform.position.y;
	}

	void FixedUpdate ()
	{
		velocity = velocity + gravity * Time.deltaTime;

		if(hasFlapped == true)
		{
			hasFlapped = false;
			velocity = velocity + flapVelocity;
		}

		velocity = Vector3.ClampMagnitude(velocity,maxSpeed);
		transform.position = transform.position + velocity * Time.deltaTime;
	}
}