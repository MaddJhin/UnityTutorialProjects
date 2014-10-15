using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameController : MonoBehaviour {

	public GameObject hazard;
	public Vector3 spawnValues;
	public int hazardCount;
	public float spawnWait;
	public float startWait;
	public float waveWait;
	public Text gameOverText;
	public Text restartText;

	bool gameOver = false;
	bool restart = false;


	// Use this for initialization
	void Start () 
	{
		gameOverText.enabled = false;
		restartText.enabled = false;
		StartCoroutine (SpawnWaves ());
	}

	void Update ()
	{
		if (restart)
		{
			if (Input.GetKeyDown (KeyCode.R))
			{
				Application.LoadLevel (Application.loadedLevel);
			}
		}
	}


	IEnumerator SpawnWaves () 
	{
		yield return new WaitForSeconds (startWait);

		while (true) 
		{
			for (int i = 0; i < hazardCount; i++)	
			{
				Vector3 spawnPosition = new Vector3 (Random.Range (-spawnValues.x, spawnValues.x), spawnValues.y, spawnValues.z);
				Quaternion spawnQuaternion = Quaternion.identity;
				
				Instantiate (hazard, spawnPosition, spawnQuaternion);
				
				yield return new WaitForSeconds (spawnWait);
			}

			yield return new WaitForSeconds (waveWait);

			if (gameOver == true){
				restartText.enabled = true;
				restart = true;
				break;
			}
		}
	}

	public void GameOver ()
	{
		gameOverText.enabled = true;
		gameOver = true;
	}

}	