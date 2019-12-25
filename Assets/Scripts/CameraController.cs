using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {
	public GameObject focusObj;

	// Start is called before the first frame update
	void Start() {

	}

	// Update is called once per frame
	void LateUpdate() {
		updatePosition();
	}

	void updatePosition() {
		float xPos = focusObj.transform.position.x;
		float yPos = focusObj.transform.position.y;
		this.transform.position = new Vector3(xPos, yPos, -10.0f);
	}
}
