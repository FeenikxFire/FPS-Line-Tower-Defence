using UnityEngine;
using System.Collections;

public class EnemyScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider otherobject)
	{
		if(otherobject.gameObject.tag == "Projectile");
		{
			Destroy(this.gameObject);
		}
	}
}
