using UnityEngine;
using System.Collections;

public class PlayerMotor : MonoBehaviour {

	public float speed;

	void Update () {

		if(Input.GetKey(KeyCode.UpArrow)) {
			this.moveUp();
		}

		if(Input.GetKey(KeyCode.DownArrow)) {
			this.moveDown();
		}

		if(Input.GetKey(KeyCode.LeftArrow)) {
			this.moveLeft();
		}
		
		if(Input.GetKey(KeyCode.RightArrow)) {
			this.moveRight();
		}

	}

	void moveUp() {
		movement(Vector3.forward);
	}

	void moveDown() {
		movement(Vector3.back);
	}

	void moveLeft() {
		movement(Vector3.left);
	}

	void moveRight() {
		movement(Vector3.right);
	}

	void movement(Vector3 direction) {
		transform.Translate(direction * speed * Time.deltaTime);
	}

}
