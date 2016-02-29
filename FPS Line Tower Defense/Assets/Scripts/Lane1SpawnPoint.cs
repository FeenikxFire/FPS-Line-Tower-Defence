using UnityEngine;
using System.Collections;

public class Lane1SpawnPoint : MonoBehaviour
{

	public GameControllerScript gameControllerScript;

	public GameObject[] EnemyList;

	// Use this for initialization
	void Start ()
	{
		gameControllerScript = GameObject.FindGameObjectWithTag ("GameController").GetComponent<GameControllerScript> ();
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}
}
