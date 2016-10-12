﻿using UnityEngine;

public class PlayerController : MonoBehaviour
{
	public GameObject bulletPrefab;
	public Transform bulletSpawn;

	void Start(){
		enabled = true;
	}

	void Update()
	{

		var x = Input.GetAxis("Horizontal") * Time.deltaTime * 150.0f;
		var z = Input.GetAxis("Vertical") * Time.deltaTime * 3.0f;

		transform.Rotate(0, x, 0);
		transform.Translate(0, 0, z);

		if (Input.GetKey(KeyCode.Space))
		{
			CmdFire();
		}
	}

	// This [Command] code is called on the Client …
	// … but it is run on the Server!
	void CmdFire()
	{
		// Create the Bullet from the Bullet Prefab
		var bullet = (GameObject)Instantiate(
			bulletPrefab,
			bulletSpawn.position,
			bulletSpawn.rotation);

		// Add velocity to the bullet
		bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward * 6;

		// Destroy the bullet after 2 seconds
		Destroy(bullet, 2.0f);
	}
		
}