using UnityEngine;
using System.Collections;

public class GameControllerScript : MonoBehaviour
{
	public GameObject Cube;
	public GameObject Lane1SpawnPoint;
	public Lane1SpawnPoint lane1spawnpoint;
	

	// Use this for initialization
	void Start ()
	{
		lane1spawnpoint = GameObject.FindGameObjectWithTag ("Lane1SpawnPoint").GetComponent<Lane1SpawnPoint> ();
	}
	
	// Update is called once per frame
	void Update ()
	{
		SpawnEnemyOfChoice ();
	}
		
	public void SpawnEnemyOfChoice()
	{
		if(Input.GetKeyDown(KeyCode.Keypad0))
		{
			Instantiate (lane1spawnpoint.EnemyList[0], Lane1SpawnPoint.transform.position, Lane1SpawnPoint.transform.rotation);
		}
		
		if(Input.GetKeyDown(KeyCode.Keypad1))
		{
			Instantiate (lane1spawnpoint.EnemyList[1], Lane1SpawnPoint.transform.position, Lane1SpawnPoint.transform.rotation);
		}
		
		if(Input.GetKeyDown(KeyCode.Keypad2))
		{
			Instantiate (lane1spawnpoint.EnemyList[2], Lane1SpawnPoint.transform.position, Lane1SpawnPoint.transform.rotation);
		}
		
		if(Input.GetKeyDown(KeyCode.Keypad3))
		{
			Instantiate (lane1spawnpoint.EnemyList[3], Lane1SpawnPoint.transform.position, Lane1SpawnPoint.transform.rotation);
		}
		
		if(Input.GetKeyDown(KeyCode.Keypad4))
		{
			Instantiate (lane1spawnpoint.EnemyList[4], Lane1SpawnPoint.transform.position, Lane1SpawnPoint.transform.rotation);
		}
		
		if(Input.GetKeyDown(KeyCode.Keypad5))
		{
			Instantiate (lane1spawnpoint.EnemyList[5], Lane1SpawnPoint.transform.position, Lane1SpawnPoint.transform.rotation);
		}
		
		if(Input.GetKeyDown(KeyCode.Keypad6))
		{
			Instantiate (lane1spawnpoint.EnemyList[6], Lane1SpawnPoint.transform.position, Lane1SpawnPoint.transform.rotation);
		}
		
		if(Input.GetKeyDown(KeyCode.Keypad7))
		{
			Instantiate (lane1spawnpoint.EnemyList[7], Lane1SpawnPoint.transform.position, Lane1SpawnPoint.transform.rotation);
		}
		
		if(Input.GetKeyDown(KeyCode.Keypad8))
		{
			Instantiate (lane1spawnpoint.EnemyList[8], Lane1SpawnPoint.transform.position, Lane1SpawnPoint.transform.rotation);
		}
		
		if(Input.GetKeyDown(KeyCode.Keypad9))
		{
			Instantiate (lane1spawnpoint.EnemyList[9], Lane1SpawnPoint.transform.position, Lane1SpawnPoint.transform.rotation);
		}
	}
}
