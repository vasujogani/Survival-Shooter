using UnityEngine;
using System.Collections;

public class AIFollower : MonoBehaviour
{
	Transform player;              
	public int speed=10;


	void Awake ()
	{
		player = GameObject.FindGameObjectWithTag ("Player").transform;
	}


	void Update ()
	{
		transform.rotation = Quaternion.Slerp(transform.rotation, 
			Quaternion.LookRotation(player.position - transform.position), 
			speed*Time.deltaTime);
		if(Mathf.Abs(Vector3.Distance(player.transform.position, transform.position))>1)
			transform.position += transform.forward * speed * Time.deltaTime;
	} 
}
