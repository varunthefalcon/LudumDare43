using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour {

	private float VerticalJumpForce = 370;
	private float horizontalMovementForce = 30;
	private float maxHorizontalMovementForce = 3;
	private Vector3 velocity;
	private bool isJumping = false;
	public bool isAlive ;
	public bool isActive ;
	private Rigidbody rb;
	// public GameObject platforms;

	private void Awake()
	{
		rb = GetComponent<Rigidbody>();
		rb.freezeRotation = true;
        
	}
	
	void Update () {
		if( isActive ){
		transform.localScale  = new Vector3(0.3f, 0.3f, 0.3f);
		
		if(Input.GetKey(KeyCode.UpArrow ) && !isJumping ){
			isJumping = true;
			rb.velocity = Vector3.zero; 
			rb.AddForce(Vector3.up * VerticalJumpForce) ;
		}
		if(Input.GetKey(KeyCode.RightArrow) && rb.velocity.x < maxHorizontalMovementForce  ){
			rb.AddForce(Vector3.right * horizontalMovementForce) ;
		}
		if(Input.GetKey(KeyCode.LeftArrow) && -rb.velocity.x < maxHorizontalMovementForce){
			rb.AddForce(Vector3.left * horizontalMovementForce) ;
		}
		if(Input.GetKeyUp("s")){
			isAlive = false;
		}
		}

		if( !isActive ){
		transform.localScale  = new Vector3(1f, 1f, 1f);
		}
		if( !isAlive ){
		Destroy(this.gameObject);
		// platforms.GetComponent<platformManager>().discountSpeed = 15f;
		}
	}
	void OnCollisionEnter(Collision col)
	{
		if (col.gameObject.tag == "subPlatform")
		{
			isJumping = false;
		}
	}
}
