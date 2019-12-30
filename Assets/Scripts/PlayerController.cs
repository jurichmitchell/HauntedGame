using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	[Tooltip("The speed multiplier for player movement.")]
		[SerializeField] private float speed = 5f;
	public float runSpeedMod = 5f;

	private bool running;

	// Start is called before the first frame update
	void Start() {
		running = false;
	}

	// Update is called once per frame
	void Update() {
		handleMovement();
	}

	void handleMovement() {
		// Check if running
		running = Input.GetButton("Run");

		// Determine the player's current speed
		float currSpeed = speed;
		currSpeed += running ? runSpeedMod : 0;

		// Get new position
		float xPos = this.transform.position.x + Input.GetAxis("Horizontal") * currSpeed * Time.deltaTime;
		float yPos = this.transform.position.y + Input.GetAxis("Vertical") * currSpeed * Time.deltaTime;
		this.transform.position = new Vector3(xPos, yPos, 0.0f);
	}
}
