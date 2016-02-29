using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UIControllerScript : MonoBehaviour 
{
	//Spawner UI stuff;
	public Canvas SpawnerUI;

	// Use this for initialization
	void Start ()
	{
		SpawnerUI = SpawnerUI.GetComponent<Canvas> ();
		SpawnerUI.enabled = false;
	}
	
	// Update is called once per frame
	void Update ()
	{
		if(Input.GetKeyDown(KeyCode.B))
		{
			if(SpawnerUI.enabled == true)
			{
				SpawnerUI.enabled = false;
			}
			else
			{
			SpawnerUI.enabled = true;
			}
		}
	}
}
