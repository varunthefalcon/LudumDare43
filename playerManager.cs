using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerManager : MonoBehaviour {
	public GameObject playerPrefab;
	private GameObject player1;
	private GameObject player2;
	 [SerializeField]
	private playerMovement player1Compo;
	 [SerializeField]
	private playerMovement player2Compo;

	// public bool player1Alive = true;
	// public bool player2Alive = true;
	// Use this for initialization
	void Start () {
		player1 =  Instantiate(playerPrefab, transform);
		player1.transform.position = new Vector3(0,2,0);
		player1Compo = player1.GetComponent<playerMovement>() ;
		player1Compo.isActive = true;
		player1Compo.isAlive = true;
		player2 =  Instantiate(playerPrefab, transform);
		player2.transform.position = new Vector3(0,0,0);
		player2Compo = player2.GetComponent<playerMovement>() ;
		player2Compo.isActive = false;
		player2Compo.isAlive = true;
	}

	// Update is called once per frame
	void Update () {

		if( !player1Compo.isAlive && !player2Compo.isAlive){
			SceneManager.LoadScene(2);
		}
		if(Input.GetKeyUp("space")){
			Debug.Log("spacebar");
			if(player1Compo.isActive == true){ // && player1Alive
				player1Compo.isActive = false;
				player2Compo.isActive = true;
				Debug.Log("spacebarplayer1Active");
				Debug.Log(player1Compo.isActive);
			}else if(player2Compo.isActive == true){ // && player2Alive
				player1Compo.isActive = true;
				player2Compo.isActive = false;
				Debug.Log("spacebarplayer2Active");
				Debug.Log(player2Compo.isActive);				
			}
		}
		// Debug.Log( player1.GetComponent<playerMovement>().isJumping );
	}
}	
