using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Obstacle : MonoBehaviour {

    PlayerCharacter playerMovement;
    SceneController sceneController;

	private void Start () {
        playerMovement = GameObject.FindObjectOfType<PlayerCharacter>();
        sceneController = GameObject.FindObjectOfType<SceneController>();
	}

    private void OnTriggerEnter(Collider other)
    {
        //if (collision.gameObject.name == "Player") {
        sceneController.playSound();
        // Kill the player
        //playerMovement.Die();
        //}
        Destroy(gameObject);
    }

    private void Update () {
	
	}
}