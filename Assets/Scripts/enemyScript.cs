using UnityEngine;
using System.Collections;

public class enemyScript : MonoBehaviour {

	private gameManagerScript gmc;

	// Use this for initialization
	void Start () {
		gmc = GameObject.FindGameObjectWithTag ("GameController").GetComponent<gameManagerScript>();
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.x > 10)
			transform.position = new Vector2((-transform.position.x+0.2f),transform.position.y);
		if (transform.position.x < -10)
			transform.position = new Vector2((-transform.position.x-0.2f),transform.position.y);
		if (transform.position.y > 5)
			transform.position = new Vector2(transform.position.x, (-transform.position.y+0.2f));
		if (transform.position.y < -5)
			transform.position = new Vector2(transform.position.x, (-transform.position.y-0.2f));

	}

	void OnTriggerEnter2D (Collider2D hit) {
		if (hit.gameObject.tag == "Player") {
			//run player dies script
			Destroy (hit.gameObject);
			gmc.playerDestroyed();
		} else if (hit.tag == "Attack") {
			Destroy(this.gameObject);
		}
	}
}
