﻿using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

	public Vector3 velocity = Vector3.zero;
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
		if(hasFlapped == true)
		{
			hasFlapped = false;
			if(velocity.y < 0)
			{
				velocity.y = 0;
			}
			velocity = velocity + flapVelocity;
		}

		velocity = Vector3.ClampMagnitude(velocity,maxSpeed);
		/* This does not work and need reworking */
		rigidbody2D.AddForce (new Vector2 (velocity.x,velocity.y));

		float angle = 0f;
		if(velocity.y < 0)
		{
			angle = Mathf.Lerp(0,-45,-velocity.y/maxSpeed);
		}
		if(velocity.y > 0)
		{
			angle = Mathf.Lerp(0,45,velocity.y/maxSpeed);
		}
		transform.rotation = Quaternion.Euler (0, 0, angle);
	}
}
