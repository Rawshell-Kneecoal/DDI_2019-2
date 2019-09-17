using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable: MonoBehaviour {

	public float xAngle, yAngle, zAngle;
	private bool rotateFlower = false;
	private bool rotateCoin = false;
	public Color newColor = Color.green;
	public GameObject infoCanvas;
	Renderer rend;
	bool isInsideZone;
	public AudioSource audioData;


	/// <summary>
	/* Awake is called when the script instance is being loaded. */
	/// </summary>
	protected virtual void Awake() {
		rend = GetComponent < Renderer > ();
	}

	/* Start is called on the frame when a script is enabled just before
	any of the Update methods is called the first time. */
	void Start() {
		infoCanvas.SetActive(false);

		audioData = GetComponent<AudioSource>();
		/* audioData.Pause(0); */
        /* audioData.Play(0);
        Debug.Log("started"); */
	}

	/* Update is called every frame, if the MonoBehaviour is enabled. */

	void Update() {
		if (isInsideZone) {
			if (Input.GetKeyDown(KeyCode.I)) {
				Interact();
			}
		}

		if(rotateFlower) {
			gameObject.transform.Rotate(Vector3.right, Space.Self);
			/* Debug.Log("Flower should be rotating!"); */

		}

		if(rotateCoin) {
			gameObject.transform.Rotate(Vector3.up, Space.Self);
			/* PlayMusic(); */
			audioData.Play(0);
			
		}
	}

	/* OnTriggerEnter is called when the Collider other enters the trigger. */
	/// <param name="other">The other Collider involved in this collision.</param>
	void OnTriggerEnter(Collider other) {
		if (!other.CompareTag("Player"))
			return;
		/* Debug.Log("You are near the cube!"); */
		isInsideZone = true;
		infoCanvas.SetActive(true);
	}

	/* OnTriggerExit is called when the Collider other has stopped touching the trigger. */
	/// <param name="other">The other Collider involved in this collision.</param>
	void OnTriggerExit(Collider other) {
		infoCanvas.SetActive(false);
		isInsideZone = false;
	}

	public virtual void Interact() {

		switch (gameObject.tag) {
			case "Flowers":
				rend.material.color = Color.white;
				rotateFlower = !rotateFlower;
				/* public void Rotate(Vector3 axis, float angle, Space relativeTo = Space.Self); */

				break;
			case "Console":
				rend.material.color = Color.cyan;
				break;
			case "Coin":
				rend.material.color = Color.white;
				rotateCoin = !rotateCoin;
				
				/* Destroy(gameObject); */
				break;
			default:
				break;
		}

		Debug.Log("interacting");
	}

	void PlayMusic()
	{
		/* int randClip = Random.Range (0, stings.Length);
		stingSource.clip = stings[randClip];
		stingSource.Play(); */
	}

}