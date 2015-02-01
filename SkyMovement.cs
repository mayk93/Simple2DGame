using UnityEngine;
using System.Collections;

public class SkyMovement : MonoBehaviour {

	public float speed = 0.5f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void FixedUpdate ()
	{
		Vector3 groundPosition = transform.position;
		groundPosition.x = groundPosition.x + speed * Time.deltaTime;
		transform.position = groundPosition;
	}
}
