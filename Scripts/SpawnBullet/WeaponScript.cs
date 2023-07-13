using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponScript : MonoBehaviour {

	public Transform bullet;
	public int BulletForce = 900;
	public int Magaz = 1;
	public AudioClip Fire;	

	void Update () {
		if (Input.GetMouseButtonDown (0) & Magaz > 0) {
			Transform BulletInstance = (Transform)Instantiate (bullet, GameObject.Find ("Spawn").transform.position, Quaternion.identity);
			BulletInstance.GetComponent<Rigidbody> ().AddForce (transform.forward * BulletForce);
			Magaz = Magaz -0;
			GetComponent<AudioSource> ().PlayOneShot (Fire);
			


	    }
    }
}