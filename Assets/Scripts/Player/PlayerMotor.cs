using UnityEngine;
using System.Collections;

public class PlayerMotor : MonoBehaviour {

	public float speed;
	public Vector3 facing = Vector3.forward;

	void Update () {

		if(Input.GetKey(KeyCode.UpArrow)) {
			move(Vector3.forward);
		}

		if(Input.GetKey(KeyCode.DownArrow)) {
			move(Vector3.back);
		}

		if(Input.GetKey(KeyCode.LeftArrow)) {
			move(Vector3.left);
		}
		
		if(Input.GetKey(KeyCode.RightArrow)) {
			move(Vector3.right);
		}

	}

	void move(Vector3 direction) {
		transform.Translate(transform.InverseTransformDirection(direction) * speed * Time.deltaTime);

		if(!Input.GetKey(KeyCode.LeftShift)) {

			Quaternion rotation = transform.rotation;

			if(direction == Vector3.forward) {
				rotation.eulerAngles = Vector3.up * 0;
			}
			else if(direction == Vector3.back) {
				rotation.eulerAngles = Vector3.up * 180;
			}
			else if(direction == Vector3.left) {
				rotation.eulerAngles = Vector3.up * 270;
			}
			else if(direction == Vector3.right) {
				rotation.eulerAngles = Vector3.up * 90;
			}

			transform.rotation = rotation;
		}
	}

}
