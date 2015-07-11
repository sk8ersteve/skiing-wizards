using UnityEngine;
using System.Collections;

public class enemyScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
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
}
