using UnityEngine;
using System.Collections;

public class Mover : MonoBehaviour 
{
	public float speed;

	Rigidbody boltRigidbody;

	void Start ()
	{
		boltRigidbody = GetComponent<Rigidbody>();

		boltRigidbody.velocity = transform.forward * speed;
	
	}
}
