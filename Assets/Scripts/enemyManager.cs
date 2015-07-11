using UnityEngine;
using System.Collections;

public class enemyManager : MonoBehaviour {

	public Transform prefab;
	public int enemyCount;
	public Vector2 spawnPosition;
	public int maxSpeed;
	


	// Use this for initialization
	void Start () {
		SpawnEnemys ();
	}

	void SpawnEnemys () {
		for (int i = enemyCount; i>0; i--) {
			Transform enemy = (Transform)Instantiate(prefab);
			Rigidbody2D rgbd = enemy.GetComponent<Rigidbody2D> ();
			// Determines which edge of screen enemy spawns from
			if (i%4 == 0) {
				spawnPosition = new Vector2(Random.Range(-10,10),5);
				enemy.localPosition = spawnPosition;
				rgbd.velocity = new Vector2(Random.Range(-maxSpeed,maxSpeed),Random.Range(-maxSpeed,-maxSpeed/2));
			}
			if (i%4 == 1) {
				spawnPosition = new Vector2(10,Random.Range(-5,5));
				enemy.localPosition = spawnPosition;
				rgbd.velocity = new Vector2(Random.Range(-maxSpeed,-maxSpeed/2),Random.Range(-maxSpeed,maxSpeed));
			}
			if (i%4 == 2) {
				spawnPosition = new Vector2(Random.Range(-10,10),-5);
				enemy.localPosition = spawnPosition;
				rgbd.velocity = new Vector2(Random.Range(-maxSpeed,maxSpeed),Random.Range(maxSpeed/2,maxSpeed));
			}
			if (i%4 == 3) {
				spawnPosition = new Vector2(-10,Random.Range(-5,5));
				enemy.localPosition = spawnPosition;
				rgbd.velocity = new Vector2(Random.Range(maxSpeed/2,maxSpeed),Random.Range(-maxSpeed,maxSpeed));
			}
		}
	}
	
	// Update is called once per frame
	void Update () {

	}
}
