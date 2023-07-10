using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSmovement : MonoBehaviour
{
    public GameObject cam;
    public float walkSpeed = 5f;
    public float hRotationSpeed = 100f;
    public float vRotationSpeed = 80f;
    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }


    void Update()
    {
        float hMovement = Input.GetAxisRaw("Horizontal");
        float vMovement = Input.GetAxisRaw("Vertical");

        Vector3 movementDirection = hMovement * Vector3.right + vMovement * Vector3.forward; transform.Translate(movementDirection * (walkSpeed * Time.deltaTime));
        float vCamRotation = Input.GetAxis("Mouse Y") * vRotationSpeed * Time.deltaTime;
        float hPlayerRotation = Input.GetAxis("Mouse X") * hRotationSpeed * Time.deltaTime;
        transform.Rotate(0f, hPlayerRotation, 0f);
        cam.transform.Rotate(-vCamRotation, 0f, 0f);
    }
}