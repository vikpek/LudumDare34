using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	bool runningDirectionRight = true;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		ProcessKeyInput ();
		Run ();
	}

	void ProcessKeyInput(){
		if (Input.GetKey (KeyCode.V)) {
			transform.position = transform.position + Vector3.up * 0.1f;
		}
		if (Input.GetKey (KeyCode.B)) {
			runningDirectionRight = !runningDirectionRight;
		}
	}

	void Run(){
		if (runningDirectionRight) {
			transform.position = transform.position + (Vector3.right*0.1f);
		}
		if (!runningDirectionRight) {
			transform.position = transform.position + (Vector3.left*0.1f);
		}
	}
}
