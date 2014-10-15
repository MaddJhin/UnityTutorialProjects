using UnityEngine;
using System.Collections;

public class PlayerShoot : MonoBehaviour {

	public GameObject bolt;
	public float fireRate = .15f;

	AudioSource weaponFire;
	Transform shotSpawn;
	float timer;

	// Use this for initialization
	void Awake () {
		shotSpawn = GetComponent<Transform>();
		weaponFire = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () 
	{
		timer += Time.deltaTime;

		if (Input.GetButton ("Fire1") && timer >= fireRate){
			timer = 0f;

			Instantiate (bolt, shotSpawn.position, shotSpawn.rotation);
			weaponFire.Play();
		}
	}
}
