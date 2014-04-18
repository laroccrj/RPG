using UnityEngine;
using System.Collections;

public class Unit : MonoBehaviour {

	public float health;

	void Damage(float damage) {
		health -= damage;

		if(health <= 0) Destroy(gameObject);
	}
}
