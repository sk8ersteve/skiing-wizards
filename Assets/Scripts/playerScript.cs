using UnityEngine;
using System.Collections;


public class playerScript : MonoBehaviour {
	
	public Transform myTrans;
	public Rigidbody2D myBody;
	
	public float force;
	public float rotationSpeed;
	public  float velocity;
	public float maxVelocity;

	// Use this for initialization
	void Start () {
		myTrans = transform;
		myBody = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {

		velocity = Mathf.Sqrt (Mathf.Pow(myBody.velocity.x, 2) + Mathf.Pow(myBody.velocity.y, 2));
		if (Input.GetKey (KeyCode.UpArrow)) {
			if (velocity < maxVelocity)
				myBody.AddForce(myTrans.up * force);
			if (velocity >= maxVelocity)
				myBody.AddForce(-myBody.velocity * force);
		}
		if (Input.GetKey (KeyCode.LeftArrow)) {
			myTrans.Rotate (Vector3.forward * rotationSpeed *Time.deltaTime);
		}
		if (Input.GetKey (KeyCode.RightArrow)) {
			myTrans.Rotate (-Vector3.forward * rotationSpeed * 	Time.deltaTime);
		}
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

