using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Pauser: MonoBehaviour {
	private bool paused = false;
	public GameObject pauseMenu;

	public void ReloadScene() {
		Scene scene = SceneManager.GetActiveScene();
		SceneManager.LoadScene(scene.name);
	}

	public void MuteUnmute() {
		AudioListener.pause = !AudioListener.pause;
	}


	// Update is called once per frame hola como estas>?
	void Update() {
		if (Input.GetKeyUp(KeyCode.P)) {
			paused = !paused;
		}

		if (paused) {
			Cursor.visible = true;
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

}