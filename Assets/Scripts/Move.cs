using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {

	public float moveSpeed = 50;

	public void Start() {
	
	}
	
	public void Update() {
		if (Input.GetAxis("Vertical") > 0.02f) {
			this.rigidbody.AddForce(transform.up * -moveSpeed);
		} else if (Input.GetAxis("Vertical") < -0.02f) {
			this.rigidbody.AddForce(transform.up * moveSpeed);
		}
	}

}
