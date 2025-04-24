using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Obstacle : MonoBehaviour {

    PlayerCharacter playerMovement;

	private void Start () {
        playerMovement = GameObject.FindObjectOfType<PlayerCharactert>();
	}

    private void OnCollisionEnter (Collision collision)
    {
        if (collision.gameObject.name == "Player") {
            // Kill the player
            playerMovement.Die();
        }
    }

    private void Update () {
	
	}
}