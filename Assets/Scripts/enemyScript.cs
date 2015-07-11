using UnityEngine;
using System.Collections;

public class enemyScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.localPosition.x > 10 || transform.localPosition.x < -10)
			transform.localPosition = new Vector2(-transform.localPosition.x,transform.localPosition.y);
		if (transform.localPosition.y > 5 || transform.localPosition.y < -5)
			transform.localPosition = new Vector2(transform.localPosition.x, -transform.localPosition.y);

	}
}
