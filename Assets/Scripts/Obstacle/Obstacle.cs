using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Obstacle : MonoBehaviour {

    PlayerCharacter playerMovement;
    private SceneController sceneController;

	private void Start () {
        playerMovement = GameObject.FindObjectOfType<PlayerCharacter>();
	}

    private void OnTriggerEnter (Collider other)
    {
        //if (collision.gameObject.name == "Player") {
            Debug.Log("TEST");
            //sceneController.playSound();
            // Kill the player
            //playerMovement.Die();
        //}
    }

    private void Update () {
	
	}
}