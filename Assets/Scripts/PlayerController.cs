using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	[Tooltip("The speed multiplier for player movement.")]
		[SerializeField] private float speed = 0.05f;


	// Start is called before the first frame update
	void Start() {
		
	}

	// Update is called once per frame
	void Update() {
		handleMovement();
	}

	void handleMovement() {
		float xPos = this.transform.position.x + Input.GetAxis("Horizontal") * speed;
		float yPos = this.transform.position.y + Input.GetAxis("Vertical") * speed;
		this.transform.position = new Vector3(xPos, yPos, 0.0f);
	}
}
