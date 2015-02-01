﻿using UnityEngine;
using System.Collections;

public class Looper : MonoBehaviour {

	int numberOfBackGroundObjects = 6;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D ( Collider2D collider )
	{
		Debug.Log ( "Triggered" + collider.name );
		float widthOfBackGroundObject = ((BoxCollider2D)collider).size.x;

		Vector3 backgroundObjectPosition = collider.transform.position;
		backgroundObjectPosition.x = backgroundObjectPosition.x + widthOfBackGroundObject * numberOfBackGroundObjects;

		collider.transform.position = backgroundObjectPosition;
	}
}
