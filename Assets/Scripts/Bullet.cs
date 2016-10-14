using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

	void OnCollisionEnter(Collision collision){
		Debug.LogError (collision.gameObject.tag);
		if (collision.gameObject.tag == "Bullet")
			return;

		Destroy(gameObject);
	}
}
