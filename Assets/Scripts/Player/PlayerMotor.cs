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
		transform.Translate(direction * speed * Time.deltaTime);

		if(!Input.GetKey(KeyCode.LeftShift))
			this.facing = direction;
	}

}
