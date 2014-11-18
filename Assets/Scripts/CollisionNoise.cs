using UnityEngine;
using System.Collections;

public class CollisionNoise : MonoBehaviour {

	//this will show up in the inspector
	public AudioClip noise;



	//internal signature. this will be called when Unity physics collides
	void OnCollisionEnter(){

		//this will play an audioclip once, at a location
		//it creates a gameobject with an audiosource, plays it, then destroys it.
		AudioSource.PlayClipAtPoint(noise, transform.position);

	}



}
