using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour {

	public float distance;
	public float speed;

	private Vector3 startPosition;
	private float difference;
	
	void Start () {
		startPosition = transform.position;
		Vector3 endPosition = transform.position + (transform.TransformDirection(Vector3.forward) * distance);
		difference = Vector3.Distance(startPosition, endPosition);
	}

	void Update () {
		Vector3 forward = transform.TransformDirection(Vector3.forward);
		transform.Translate(forward * this.speed * Time.deltaTime);

		if(Vector3.Distance(this.startPosition, transform.position) > this.difference) {
			Destroy(gameObject);
		}
	}
}
