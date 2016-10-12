using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

	void OnCollisionEnter(Collision collision){
		if (collision.gameObject.tag == "Bullet")
			return;
		var hit = collision.gameObject;

		Destroy(gameObject);
	}
}
