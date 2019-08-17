using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetector: MonoBehaviour {
    // Start is called before the first frame update
    void Start() {
        Debug.Log("Juego iniciado");
    }

    // Update is called once per frame
    void Update() {
        /* Debug.Log("Game ongoing"); */
    }

    void OnCollisionEnter(Collision collision) {
        Debug.Log("Collision detected with " + collision.gameObject.name);

    }

}