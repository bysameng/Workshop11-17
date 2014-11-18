using UnityEngine;
using System.Collections;

public class CubeSpawner : MonoBehaviour {


	//this will show up in the inspector
	public GameObject cubePrefab;


	// Use this for initialization
	void Start () {
		StartCoroutine(SpawnCube());
	}


	//coroutines run on a seperate thread
	//do not overuse them! they are a difficult beast
	//use this as a teaser
	IEnumerator SpawnCube(){

		while (true){
			Instantiate(cubePrefab, transform.position, Quaternion.identity);
			transform.position = new Vector3(Random.Range(-10f, 10f), 10f, 0f);

			yield return new WaitForSeconds(1f);
		}

	}

}
