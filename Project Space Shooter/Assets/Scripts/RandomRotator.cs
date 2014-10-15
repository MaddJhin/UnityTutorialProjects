using UnityEngine;
using System.Collections;

public class RandomRotator : MonoBehaviour {

	public float tumble;

	Rigidbody asteroidRigidbody;

	// Use this for initialization
	void Awake () {
		asteroidRigidbody = GetComponent<Rigidbody>();
	}

	void Start () 
	{
		asteroidRigidbody.angularVelocity = Random.insideUnitSphere * tumble;
	}
}
