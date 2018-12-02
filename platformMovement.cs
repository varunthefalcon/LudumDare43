using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformMovement : MonoBehaviour {

	private platformManager parent;
	// Update is called once per frame
	void Start () {
		parent = gameObject.GetComponentInParent<platformManager>();
	}
	void FixedUpdate () {
		transform.position += parent.speed * Vector3.down;
	}
}
