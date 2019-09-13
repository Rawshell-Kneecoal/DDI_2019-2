using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController: MonoBehaviour {

    // Start is called before the first frame update

    public Transform cameraTarget;

    [Range(1, 10)]

    public float rotationSpeed = 1f; // refresh rate -> 1 unidad por segundo

    public Vector2 limitY = new Vector2(-30, 30);
    private float mouseX, mouseY;
    void Start() {
        Cursor.visible = false;
        /* Cursor.lockState = CursorLockMode.Locked; */
    }

    // Update is called once per frame
    void Update() {
        // Getting values of 
        mouseX += Input.GetAxis("Mouse X") * rotationSpeed;
        mouseY += Input.GetAxis("Mouse Y") * rotationSpeed;

        mouseY = Mathf.Clamp(mouseY, limitY.x,limitY.y);  // ajustar movimiento of mouse in eje Y

        // What is Quaternion? read about this
        cameraTarget.rotation = Quaternion.Euler(mouseY, mouseY, 0);
        transform.LookAt(cameraTarget);

        Debug.Log("Mouse X = "+ mouseX + " Mouse Y = " + mouseY);
    }
}