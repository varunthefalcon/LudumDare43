using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformManager : MonoBehaviour {

	public float speed = 0f;
	public float discountSpeed = 0f;
	// Update is called once per frame
	void FixedUpdate () {
		speed = (Time.timeSinceLevelLoad - discountSpeed) / 3000;
		discountSpeed = 0f;
	}
}
