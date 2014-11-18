using UnityEngine;
using System.Collections;

public class ObjectThrower : MonoBehaviour 
{

	//this will show up in the inspector
	public GameObject throwPrefab;


	// Update is called once per frame
	void Update () 
	{
		//we will write code here
//		Debug.Log("thank our sponsors microsoft for being awesome");
		//you should comment your code with double forward slashes

		if (Input.GetKeyDown(KeyCode.Space)){
			Debug.Log("user has pressed space!!!");

			//this line actually spawns it
			GameObject spawnedCube = 
				(GameObject)Instantiate(throwPrefab, 
				                        transform.position, Quaternion.identity);

			//make sure that the prefab has a rigidbody or this line will error!
			//this tells the rigidbody to PUSH itself
			spawnedCube.rigidbody.AddForce(transform.forward * 1000f);
		}


		//get input axis
		float xAxis = Input.GetAxis("Horizontal");
		float yAxis = Input.GetAxis("Vertical");


		Vector3 movement = new Vector3(xAxis, yAxis, 0f) * Time.deltaTime;
		transform.Translate(movement * Time.deltaTime);

	}



}
