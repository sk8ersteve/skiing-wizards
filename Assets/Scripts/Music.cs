using UnityEngine;
using System.Collections;

public class Music : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	if (Input.GetKeyDown (KeyCode.RightArrow) || Input.GetKeyDown (KeyCode.LeftArrow)) {
			if(GetComponent<AudioSource>().isPlaying != true){
			GetComponent<AudioSource> ().Play ();
			}
		}
	}
}
