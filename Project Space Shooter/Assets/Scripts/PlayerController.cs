using UnityEngine;
using System.Collections;

[System.Serializable]
public class Boundary 
{
	public float xMin, xMax, zMin, zMax;
}

public class PlayerController : MonoBehaviour {

	public float speed = 10f;
	public float tilt;
	public Boundary boundary;

	Vector3 movement;
	Rigidbody playerRigibody;


	void Awake ()
	{
		playerRigibody = GetComponent<Rigidbody>();
	}

	void FixedUpdate()
	{
		float moveHorizontal = Input.GetAxisRaw ("Horizontal");
		float moveVertical = Input.GetAxisRaw ("Vertical");

		movement.Set (moveHorizontal, 0.0f, moveVertical);

		playerRigibody.velocity = movement * speed;

		playerRigibody.position = new Vector3
		(
			Mathf.Clamp (playerRigibody.position.x, boundary.xMin, boundary.xMax), 
			0.0f, 
			Mathf.Clamp (playerRigibody.position.z, boundary.zMin, boundary.zMax)
		);

		playerRigibody.rotation = Quaternion.Euler (0.0f, 0.0f, playerRigibody.velocity.x * -tilt);
	}
}
