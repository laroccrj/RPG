using UnityEngine;
using System.Collections;

public class Spell : MonoBehaviour {

	public Projectile projectile;

	public float distance;

	void Update () {

		//For testing
		if(Input.GetKeyDown(KeyCode.Space)) Cast();

	}

	void Cast() {
		Projectile projectile = (Projectile)GameObject.Instantiate(this.projectile, transform.position, transform.rotation);
		projectile.distance = this.distance;
	}
}
