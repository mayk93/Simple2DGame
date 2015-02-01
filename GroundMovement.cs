using UnityEngine;
using System.Collections;

public class GroundMovement : MonoBehaviour {

	public float speed = -1f;

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
