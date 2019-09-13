using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderToo: MonoBehaviour {
    // Start is called before the first frame update

    public Material[] cubeMaterials;
    public bool insideZone;
    public GameObject infoCanvas;


    private Rigidbody rigidb;
    public Vector3 forceVector;

    void Start() {
        infoCanvas.SetActive(false);
        rigidb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.C) && insideZone) {

            GetComponent < Renderer > ().material = cubeMaterials[Random.Range(0, cubeMaterials.Length)]; /* <- sonido color */
            rigidb.AddForce(forceVector, ForceMode.Force);
            rigidb.AddTorque(forceVector,ForceMode.Force);
        }
    }
    void onTriggerEnter(Collider other) {

        if (other.CompareTag("Player")) {
            /* add this tag to fps controller */
            Debug.Log("Player touched");
            insideZone = true;
            infoCanvas.SetActive(true);
        }

    }

    void OnTriggerExit(Collider other) {
        if (other.CompareTag("Player")) {
            /* <-- add this tag to fps controller */
            Debug.Log("Player out");
            insideZone = false;
            infoCanvas.SetActive(false);
        }
    }
}