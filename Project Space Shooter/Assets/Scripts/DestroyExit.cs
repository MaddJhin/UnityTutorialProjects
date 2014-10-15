using UnityEngine;
using System.Collections;

public class DestroyExit : MonoBehaviour {

	void OnTriggerExit (Collider collider)
	{
		Destroy (collider.gameObject);
	}
}
