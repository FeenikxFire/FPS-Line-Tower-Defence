using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour {

	private Transform myTransform;
	public int projectileSpeed;
	public GameObject muzzle;

	// Use this for initialization
	void Start ()
	{
		myTransform = this.transform;
		muzzle = GameObject.FindGameObjectWithTag ("Muzzle");
	}
	
	// Update is called once per frame
	void Update ()
	{
		myTransform.Translate (Vector3.forward * Time.deltaTime * projectileSpeed);
	}

	//void OnCollisionEnter()
	//{
	//	Destroy (this.gameObject);
	//}
}
