using UnityEngine;
using System.Collections;

public class Pauser: MonoBehaviour {
	private bool paused = false;
	public GameObject pauseMenu;

	// Update is called once per frame
	void Update() {
		if (Input.GetKeyUp(KeyCode.P)) {
			paused = !paused;
		}

		if (paused) {
			Time.timeScale = 0;
			pauseMenu.SetActive(true);

		} else {
			Time.timeScale = 1;
			pauseMenu.SetActive(false);

		}

	}

	public void ContinueGame() {
		paused = false;

	}

	/* 
	add:
	pause music
	reiniciar partida */

	/* research about load scene */
}