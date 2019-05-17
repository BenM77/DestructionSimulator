// checks for input from W, A, S, D to move the camera
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour {
    public float cameraSpeed;
    public float rotateSpeed;
    float rotateX = 0, rotateY = 0;
	void Update () {
        // else ifs not used because if two keys are pressed together they will cancel or add to each other
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(new Vector3(-cameraSpeed * Time.deltaTime, 0, 0)); // the new position is the old position
                                                                            // plus speed * time in one direction
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(new Vector3(cameraSpeed * Time.deltaTime, 0, 0));
        }
        if (Input.GetKey(KeyCode.Q))
        {
            transform.Translate(new Vector3(0, cameraSpeed * Time.deltaTime, 0));
        }
        if (Input.GetKey(KeyCode.E))
        {
            transform.Translate(new Vector3(0, -cameraSpeed * Time.deltaTime, 0));
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(new Vector3(0, 0, cameraSpeed * Time.deltaTime));
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(new Vector3(0, 0, -cameraSpeed * Time.deltaTime));
        }

        //rotate the camera based on the mouse movement
        rotateX += rotateSpeed * Input.GetAxis("Mouse X");
        rotateY -= rotateSpeed * Input.GetAxis("Mouse Y");

        transform.eulerAngles = new Vector3(rotateY, rotateX, 0.0f);
    }
}
