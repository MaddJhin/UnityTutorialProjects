using UnityEngine;
using System.Collections;

public class DestroyByTime : MonoBehaviour {

	public float lifetime = 2f;

	// Use this for initialization
	void Start () {
		Destroy (gameObject, lifetime);
	}
}
