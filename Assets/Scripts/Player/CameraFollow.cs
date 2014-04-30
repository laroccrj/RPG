using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

	public GameObject player;

	void Update() {
		transform.position = player.transform.position + (Vector3.up * 10);
	}
}
