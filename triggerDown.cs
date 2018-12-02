using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class triggerDown : MonoBehaviour {

void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.tag == "platform") {
		col.gameObject.transform.position = new Vector3(0,6.5f,0);		
		}

		if (col.gameObject.tag == "Player") {
		 SceneManager.LoadScene(2);	
		}
	}
}
