using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour {

	public float distance;
	public float speed;
	public Vector3 direction;

	private Vector3 startPosition;
	private float difference;
	
	void Start () {
		startPosition = transform.position;
		Vector3 endPosition = transform.position + (direction * distance);
		difference = Vector3.Distance(startPosition, endPosition);
	}

	void Update () {
		transform.Translate(direction * this.speed * Time.deltaTime);

		if(Vector3.Distance(this.startPosition, transform.position) > this.difference) {
			Destroy(gameObject);
		}
	}
}
