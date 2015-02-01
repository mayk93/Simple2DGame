using UnityEngine;
using System.Collections;

public class BirdTracker : MonoBehaviour {

	Transform player;

	float offsetX;

	// Use this for initialization
	void Start () {
		GameObject playerGameObject = GameObject.FindGameObjectWithTag ("Player");
		if(playerGameObject != null)
		{
			player = playerGameObject.transform;
			offsetX = transform.position.x - player.position.x;
		}
		else
		{
			Debug.Log("Wtf?");
			return;
		}
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(player != null)
		{
			Vector3 currentPosition = transform.position;	
			currentPosition.x = player.position.x + offsetX;
			transform.position = currentPosition;
		}
	}
}
