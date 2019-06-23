using UnityEngine;
using System.Collections;

public class ShootEnemy : MonoBehaviour {

	public float speed;
	public float stoppingDistance;
	public float nearDistance;
	public float startTimeShots;
	public float timeShots;


	public Vector3 bulletOffset = new Vector3(0, 0.5f, 0);
	
	public GameObject bulletPrefab;
	private Transform player;



	void Start() {
		//Zodat hij de Bullet vind.
		player = GameObject.FindGameObjectWithTag("Player").transform;
		bulletPrefab = GameObject.Find("bulletPrefab");

	}

	// Update is called once per frame
	void Update () {
		
		// Moves the enemy towards MC
		if(Vector2.Distance(transform.position, player.position) < nearDistance){
			transform.position = Vector2.MoveTowards(transform.position, player.position, -speed *Time.deltaTime);
		} else if (Vector2.Distance(transform.position, player.position) > stoppingDistance){
			transform.position = Vector2.MoveTowards(transform.position, player.position, speed *Time.deltaTime);
		} else if(Vector2.Distance(transform.position, player.position) > stoppingDistance && Vector2.Distance(transform.position, player.position) > nearDistance){
			transform.position = this.transform.position;
		}

		//Makes enemy shoot.
		if (timeShots <= 0){
			Instantiate(Resources.Load("bulletPrefab"), transform.position, Quaternion.identity);
			timeShots = startTimeShots;
		} else{
			timeShots -= Time.deltaTime;
		}
	}
}
