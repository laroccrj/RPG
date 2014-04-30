using UnityEngine;
using System.Collections;

public class Spell : MonoBehaviour {

	public Projectile projectile;
	public float distance;
	public int angel;
	public PlayerMotor motor;

	void Update () {

		//For testing
		if(Input.GetKeyDown(KeyCode.Space)) Cast();

	}

	void Cast() {

		if(this.angel == 0) {
			SpawnProjectile(motor.facing);
		}
		else {
			 
		}
	}

	void SpawnProjectile(Vector3 direction) {
		Projectile projectile = (Projectile)GameObject.Instantiate(this.projectile, transform.position, transform.rotation);
		projectile.distance = this.distance;
	}
}
