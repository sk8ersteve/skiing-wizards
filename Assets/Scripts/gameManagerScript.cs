using UnityEngine;
using System.Collections;

public class gameManagerScript : MonoBehaviour {

	public Transform playerPrefab;
	public int lives = 3;

	// Use this for initialization
	void Start () {

		Transform player = (Transform)Instantiate(playerPrefab);
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public IEnumerator playerDestroyedIEn () {
		if (lives > 0) {
			lives--;
			yield return new WaitForSeconds (2);
			Transform player = (Transform)Instantiate (playerPrefab);
		} else {
			//run game over script

		}


	}

	public void playerDestroyed() {
		StartCoroutine(playerDestroyedIEn());
	}
}
